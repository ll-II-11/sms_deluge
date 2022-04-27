using SmsDeluge.WinForm.Services;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsDeluge.WinForm.Views
{
    public partial class MainForm : UIForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var mobile = this.tbMobile.Text.Trim();
            if (!Regex.IsMatch(mobile, "^(13[0-9]|14[01456879]|15[0-3,5-9]|16[2567]|17[0-8]|18[0-9]|19[0-3,5-9])\\d{8}$"))
            {
                this.tbMessage.AppendText("手机号码错误\r\n");
                return;
            }
            var t_count = this.tbSendCount.Text.Trim();
            if (!int.TryParse(t_count, out int count))
            {
                this.tbMessage.AppendText("发送次数错误\r\n");
                return;
            }
            var t_interval = this.tbSendInterval.Text.Trim();
            if (!int.TryParse(t_interval, out int interval))
            {
                this.tbMessage.AppendText("发送间隔错误\r\n");
                return;
            }
            SmsService.IsRun = true;
            Task.Run(async () => {
                await new SmsService().Send(mobile, count, interval, this.tbMessage, this.gbTask);
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SmsService.IsRun = false;
        }
    }
}
