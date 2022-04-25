using SmsDeluge.WinForm.Extensions;
using SmsDeluge.WinForm.Models;
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
        public TextBox TbMessage { get; private set; }
        public GroupBox GbTask { get; private set; }

        public SmsService()
        {
            settingModel = new SettingModel();
            Token  = Guid.NewGuid().ToString("N");
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
            var liveTaskCount = 4;
            GbTask.Invoke(new Action(() => {
                liveTaskCount = GbTask.Controls.Count;
            }));
            if (liveTaskCount >= 4)
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
                }
            }
        }

        private void CalcTask()
        {
            GbTask.Invoke(new Action(() => {
                var lables = GbTask.Controls.Find($"lbl_{Token}", true);
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
                    if (CurrentSendCount >= NeedSendCount)
                    {
                        return;
                    }
                    var lable = new Label();
                    lable.Name = $"lbl_{Token}";
                    lable.Text = $"{CurrentSendCount}-{Mobile}";
                    lable.Height = 12;
                    var points = new List<Point>();
                    points.Add(new Point(15, 17));
                    points.Add(new Point(115, 17));
                    points.Add(new Point(215, 17));
                    points.Add(new Point(315, 17));
                    foreach (Control control in GbTask.Controls)
                    {
                        if (points.Contains(control.Location))
                        {
                            points.Remove(control.Location);
                        }
                    }
                    lable.Location = points[0];
                    GbTask.Controls.Add(lable);
                }
            }));
        }
    }
}
