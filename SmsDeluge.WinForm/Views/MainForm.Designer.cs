
namespace SmsDeluge.WinForm.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.gbTask = new Sunny.UI.UIFlowLayoutPanel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.tbMessage = new Sunny.UI.UITextBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.tbSendInterval = new Sunny.UI.UITextBox();
            this.tbMobile = new Sunny.UI.UITextBox();
            this.tbSendCount = new Sunny.UI.UITextBox();
            this.btnStart = new Sunny.UI.UISymbolButton();
            this.btnStop = new Sunny.UI.UISymbolButton();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.gbTask);
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox3.Location = new System.Drawing.Point(384, 37);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(136, 364);
            this.uiGroupBox3.TabIndex = 12;
            this.uiGroupBox3.Text = "任务";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // gbTask
            // 
            this.gbTask.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbTask.Location = new System.Drawing.Point(4, 25);
            this.gbTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTask.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbTask.Name = "gbTask";
            this.gbTask.Padding = new System.Windows.Forms.Padding(2);
            this.gbTask.ShowText = false;
            this.gbTask.Size = new System.Drawing.Size(128, 334);
            this.gbTask.TabIndex = 4;
            this.gbTask.Text = "uiFlowLayoutPanel1";
            this.gbTask.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gbTask.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.tbMessage);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(4, 140);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(372, 261);
            this.uiGroupBox2.TabIndex = 11;
            this.uiGroupBox2.Text = "消息";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbMessage
            // 
            this.tbMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMessage.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMessage.Location = new System.Drawing.Point(4, 24);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMessage.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ShowScrollBar = true;
            this.tbMessage.ShowText = false;
            this.tbMessage.Size = new System.Drawing.Size(364, 232);
            this.tbMessage.TabIndex = 6;
            this.tbMessage.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.tbMessage.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiMarkLabel3);
            this.uiGroupBox1.Controls.Add(this.uiMarkLabel2);
            this.uiGroupBox1.Controls.Add(this.uiMarkLabel1);
            this.uiGroupBox1.Controls.Add(this.tbSendInterval);
            this.uiGroupBox1.Controls.Add(this.tbMobile);
            this.uiGroupBox1.Controls.Add(this.tbSendCount);
            this.uiGroupBox1.Controls.Add(this.btnStart);
            this.uiGroupBox1.Controls.Add(this.btnStop);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 37);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(372, 93);
            this.uiGroupBox1.TabIndex = 10;
            this.uiGroupBox1.Text = "设置";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel3.Location = new System.Drawing.Point(8, 60);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel3.TabIndex = 10;
            this.uiMarkLabel3.Text = "发送间隔";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel2.Location = new System.Drawing.Point(225, 26);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel2.TabIndex = 9;
            this.uiMarkLabel2.Text = "发送次数";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(8, 26);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel1.TabIndex = 8;
            this.uiMarkLabel1.Text = "手机号码";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbSendInterval
            // 
            this.tbSendInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSendInterval.DoubleValue = 1000D;
            this.tbSendInterval.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSendInterval.IntValue = 1000;
            this.tbSendInterval.Location = new System.Drawing.Point(89, 60);
            this.tbSendInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSendInterval.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSendInterval.Name = "tbSendInterval";
            this.tbSendInterval.ShowText = false;
            this.tbSendInterval.Size = new System.Drawing.Size(60, 25);
            this.tbSendInterval.TabIndex = 7;
            this.tbSendInterval.Text = "1000";
            this.tbSendInterval.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSendInterval.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbSendInterval.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbMobile
            // 
            this.tbMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMobile.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMobile.Location = new System.Drawing.Point(89, 25);
            this.tbMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMobile.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.ShowText = false;
            this.tbMobile.Size = new System.Drawing.Size(100, 25);
            this.tbMobile.TabIndex = 1;
            this.tbMobile.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMobile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbSendCount
            // 
            this.tbSendCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSendCount.DoubleValue = 100D;
            this.tbSendCount.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSendCount.IntValue = 100;
            this.tbSendCount.Location = new System.Drawing.Point(306, 25);
            this.tbSendCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSendCount.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSendCount.Name = "tbSendCount";
            this.tbSendCount.ShowText = false;
            this.tbSendCount.Size = new System.Drawing.Size(60, 25);
            this.tbSendCount.TabIndex = 5;
            this.tbSendCount.Text = "100";
            this.tbSendCount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSendCount.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbSendCount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.LightStyle = true;
            this.btnStart.Location = new System.Drawing.Point(226, 60);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.btnStart.Size = new System.Drawing.Size(30, 25);
            this.btnStart.Symbol = 61515;
            this.btnStart.TabIndex = 2;
            this.btnStart.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.LightStyle = true;
            this.btnStop.Location = new System.Drawing.Point(256, 60);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.btnStop.Size = new System.Drawing.Size(30, 25);
            this.btnStop.Symbol = 61516;
            this.btnStop.TabIndex = 3;
            this.btnStop.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(525, 405);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowRadius = false;
            this.ShowRect = false;
            this.ShowShadow = true;
            this.ShowTitleIcon = true;
            this.Text = "短信压力测试";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIFlowLayoutPanel gbTask;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox tbMessage;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UITextBox tbSendInterval;
        private Sunny.UI.UITextBox tbMobile;
        private Sunny.UI.UITextBox tbSendCount;
        private Sunny.UI.UISymbolButton btnStart;
        private Sunny.UI.UISymbolButton btnStop;
    }
}