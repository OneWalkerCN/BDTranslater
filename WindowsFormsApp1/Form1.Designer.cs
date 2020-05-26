namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gapTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SecrateTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.APPID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.APIAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TranslateTimes = new System.Windows.Forms.TextBox();
            this.InputTxt = new System.Windows.Forms.RichTextBox();
            this.OutPutTxt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Speech = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 415);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(568, 23);
            this.progress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.gapTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SecrateTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.APPID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.APIAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TranslateTimes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // gapTime
            // 
            this.gapTime.Location = new System.Drawing.Point(199, 37);
            this.gapTime.Name = "gapTime";
            this.gapTime.Size = new System.Drawing.Size(45, 21);
            this.gapTime.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "间隔时间(ms):";
            // 
            // SecrateTxt
            // 
            this.SecrateTxt.Location = new System.Drawing.Point(69, 131);
            this.SecrateTxt.Name = "SecrateTxt";
            this.SecrateTxt.PasswordChar = '◾';
            this.SecrateTxt.Size = new System.Drawing.Size(175, 21);
            this.SecrateTxt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "密钥:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(92, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "*注意：上方参数不可为空";
            // 
            // APPID
            // 
            this.APPID.Location = new System.Drawing.Point(69, 101);
            this.APPID.Name = "APPID";
            this.APPID.Size = new System.Drawing.Size(175, 21);
            this.APPID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = " APP ID:";
            // 
            // APIAddress
            // 
            this.APIAddress.Location = new System.Drawing.Point(69, 70);
            this.APIAddress.Name = "APIAddress";
            this.APIAddress.Size = new System.Drawing.Size(175, 21);
            this.APIAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "接口地址:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "翻译次数:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TranslateTimes
            // 
            this.TranslateTimes.Location = new System.Drawing.Point(69, 37);
            this.TranslateTimes.Name = "TranslateTimes";
            this.TranslateTimes.Size = new System.Drawing.Size(40, 21);
            this.TranslateTimes.TabIndex = 0;
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(268, 35);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(312, 183);
            this.InputTxt.TabIndex = 3;
            this.InputTxt.Text = "";
            // 
            // OutPutTxt
            // 
            this.OutPutTxt.Location = new System.Drawing.Point(12, 251);
            this.OutPutTxt.Name = "OutPutTxt";
            this.OutPutTxt.Size = new System.Drawing.Size(489, 158);
            this.OutPutTxt.TabIndex = 4;
            this.OutPutTxt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "翻译结果";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "翻译文本";
            // 
            // Speech
            // 
            this.Speech.Location = new System.Drawing.Point(511, 287);
            this.Speech.Name = "Speech";
            this.Speech.Size = new System.Drawing.Size(71, 26);
            this.Speech.TabIndex = 7;
            this.Speech.Text = "朗读";
            this.Speech.UseVisualStyleBackColor = true;
            this.Speech.Click += new System.EventHandler(this.Speech_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(9, 164);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(72, 36);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 446);
            this.Controls.Add(this.Speech);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutPutTxt);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "百 度 翻 译 官";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox APPID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox APIAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TranslateTimes;
        private System.Windows.Forms.RichTextBox InputTxt;
        private System.Windows.Forms.RichTextBox OutPutTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SecrateTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gapTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Speech;
        private System.Windows.Forms.Button saveBtn;
    }
}

