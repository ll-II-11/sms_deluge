using SmsDeluge.WinForm.Extensions;
using SmsDeluge.WinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsDeluge.WinForm.Services
{
    public class SmsService
    {
        private static SettingModel settingModel;
        public static bool isRun = false;

        public string Mobile { get; private set; }
        public int CurrentSendCount { get; private set; }
        public int NeedSendCount { get; private set; }
        public TextBox TbMessage { get; private set; }
        public GroupBox GbTask { get; private set; }
        public int LiveTaskCount { get; private set; }

        public SmsService()
        {
            settingModel = new SettingModel();
        }

        public async Task Send(string mobile, int needSendCount, TextBox tbMessage, GroupBox gbTask)
        {
            Mobile = mobile;
            NeedSendCount = needSendCount;
            TbMessage = tbMessage;
            GbTask = gbTask;
            if (!IsNewTask())
            {
                return;
            }
            await StartTask();
        }

        private bool IsNewTask()
        {
            int currentLableCount = 0;
            GbTask.Invoke(new Action(() => {
                currentLableCount = GbTask.Controls.Find($"lbl{Mobile}", true).Length;
                LiveTaskCount = GbTask.Controls.Count;
            }));
            if (LiveTaskCount >= 4 || currentLableCount >= 1)
            {
                return false;
            }
            return true;
        }

        private async Task StartTask()
        {
            var settings = await settingModel.GetSettingsAsync(Mobile);
            if (settings == null || settings.Count <= 0)
            {
                TbMessage.BeginInvoke(new Action(() => {
                    TbMessage.AppendText($"<{DateTime.Now.ToString("dd-HH:mm:ss")}>未配置接口数据\r\n");
                }));
            }
            for (int i = 0; i < NeedSendCount; i++)
            {
                foreach (var setting in settings)
                {
                    if (!isRun)
                    {
                        CurrentSendCount = NeedSendCount;
                        CalcTask();
                        return;
                    }
                    var url = new Uri(setting.Url);
                    var method = new HttpMethod(setting.Method);
                    var response = await url.SendHttpRequestAsync(method, setting.Header, setting.Content);
                    //if (response == null)
                    //{
                    //    TbMessage.BeginInvoke(new Action(() => {
                    //        TbMessage.AppendText($"<{DateTime.Now.ToString("dd-HH:mm:ss")}>接口失效<{url.Host}>\r\n");
                    //    }));
                    //    continue;
                    //}
                    //if (!string.IsNullOrWhiteSpace(setting.ResultRegex))
                    //{
                    //    var regex = new Regex(setting.ResultRegex);
                    //    if (!regex.IsMatch(response))
                    //    {
                    //        TbMessage.BeginInvoke(new Action(() => {
                    //            TbMessage.AppendText($"<{DateTime.Now.ToString("dd-HH:mm:ss")}>响应数据与正则不匹配<{url.Host}>\r\n");
                    //        }));
                    //        continue;
                    //    }
                    //}
                    TbMessage.BeginInvoke(new Action(() => {
                        TbMessage.AppendText($"<{DateTime.Now.ToString("dd-HH:mm:ss")}>发送请求<{setting.Url}>响应数据<{response}>\r\n");
                    }));
                    CurrentSendCount++;
                    CalcTask();
                    if (CurrentSendCount >= NeedSendCount)
                    {
                        TbMessage.BeginInvoke(new Action(() => {
                            TbMessage.AppendText($"<{DateTime.Now.ToString("dd-HH:mm:ss")}>请求全部发送完成\r\n");
                        }));
                        CalcTask();
                        return;
                    }
                }
            }
        }

        private void CalcTask()
        {
            GbTask.Invoke(new Action(() => {
                var lables = GbTask.Controls.Find($"lbl{Mobile}", true);
                if (lables.Length >= 1)
                {
                    var lable = (Label)lables[0];
                    if (CurrentSendCount >= NeedSendCount)
                    {
                        GbTask.Controls.Remove(lable);
                    }
                    else
                    {
                        lable.Text = $"{CurrentSendCount}-{Mobile}";
                    }
                }
                else
                {
                    var lable = new Label();
                    lable.Name = $"lbl{Mobile}";
                    lable.Text = $"{CurrentSendCount}-{Mobile}";
                    lable.Height = 12;
                    lable.Location = new System.Drawing.Point(LiveTaskCount * 100 + 15, 17);
                    GbTask.Controls.Add(lable);
                }
            }));
        }
    }
}
