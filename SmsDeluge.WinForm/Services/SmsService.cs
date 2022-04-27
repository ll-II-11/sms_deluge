using SmsDeluge.WinForm.Extensions;
using SmsDeluge.WinForm.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static bool IsRun { get; set; }
        public string Token { get; private set; }
        public string Mobile { get; private set; }
        public int CurrentSendCount { get; private set; }
        public int NeedSendCount { get; private set; }
        public int SendInterval { get; private set; }
        public UITextBox TbMessage { get; private set; }
        public UIFlowLayoutPanel GbTask { get; private set; }

        public SmsService()
        {
            settingModel = new SettingModel();
            Token  = Guid.NewGuid().ToString("N");
        }

        public async Task Send(string mobile, int needSendCount, int sendInterval, UITextBox tbMessage, UIFlowLayoutPanel gbTask)
        {
            Mobile = mobile;
            NeedSendCount = needSendCount;
            SendInterval = sendInterval;
            TbMessage = tbMessage;
            GbTask = gbTask;
            await StartTask();
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
                    if (!IsRun)
                    {
                        CurrentSendCount = NeedSendCount;
                        CalcTask();
                        return;
                    }
                    var url = new Uri(setting.Url);
                    var method = new HttpMethod(setting.Method);
                    var response = await url.SendHttpRequestAsync(method, setting.Header, setting.Content);
                    TbMessage.BeginInvoke(new Action(() => {
                        TbMessage.AppendText($"<{DateTime.Now.ToString("dd-HH:mm:ss")}>发送请求<{setting.Url}>响应数据<{response}>\r\n");
                    }));
                    CurrentSendCount++;
                    CalcTask();
                    if (CurrentSendCount >= NeedSendCount)
                    {
                        CalcTask();
                        return;
                    }
                    Thread.Sleep(SendInterval);
                }
            }
        }

        private void CalcTask()
        {
            GbTask.Invoke(new Action(() => {
                var lable = GbTask.GetControl<Label>($"lbl_{Token}");
                if (lable != null)
                {
                    if (CurrentSendCount >= NeedSendCount)
                    {
                        GbTask.Remove(lable);
                    }
                    else
                    {
                        lable.Text = $"{CurrentSendCount}-{Mobile}";
                    }
                }
                else
                {
                    if (CurrentSendCount >= NeedSendCount)
                    {
                        return;
                    }
                    lable = new Label();
                    lable.Name = $"lbl_{Token}";
                    lable.Text = $"{CurrentSendCount}-{Mobile}";
                    lable.Height = 20;
                    lable.Font = new Font("微软雅黑", 9);
                    GbTask.Controls.Add(lable);
                }
            }));
        }
    }
}
