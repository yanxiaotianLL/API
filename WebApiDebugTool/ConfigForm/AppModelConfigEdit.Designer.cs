namespace WebApiDebugTool.ConfigForm
{
    partial class AppModelConfigEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppModelConfigEdit));
            this.gb_Account = new System.Windows.Forms.GroupBox();
            this.cbxAppDefaultTwo = new System.Windows.Forms.RadioButton();
            this.cbxAppDefaultOne = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDefaultUrlTwo = new System.Windows.Forms.TextBox();
            this.tbxDefaultUrlOne = new System.Windows.Forms.TextBox();
            this.tbxAppSecret = new System.Windows.Forms.TextBox();
            this.tbxAppID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gb_Account.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Account
            // 
            this.gb_Account.Controls.Add(this.cbxAppDefaultTwo);
            this.gb_Account.Controls.Add(this.cbxAppDefaultOne);
            this.gb_Account.Controls.Add(this.label8);
            this.gb_Account.Controls.Add(this.label7);
            this.gb_Account.Controls.Add(this.tbxDefaultUrlTwo);
            this.gb_Account.Controls.Add(this.tbxDefaultUrlOne);
            this.gb_Account.Controls.Add(this.tbxAppSecret);
            this.gb_Account.Controls.Add(this.tbxAppID);
            this.gb_Account.Controls.Add(this.label3);
            this.gb_Account.Controls.Add(this.label2);
            this.gb_Account.Controls.Add(this.label1);
            this.gb_Account.Location = new System.Drawing.Point(42, 19);
            this.gb_Account.Name = "gb_Account";
            this.gb_Account.Size = new System.Drawing.Size(649, 149);
            this.gb_Account.TabIndex = 1;
            this.gb_Account.TabStop = false;
            this.gb_Account.Text = "APP服务账户配置";
            // 
            // cbxAppDefaultTwo
            // 
            this.cbxAppDefaultTwo.AutoSize = true;
            this.cbxAppDefaultTwo.Location = new System.Drawing.Point(543, 115);
            this.cbxAppDefaultTwo.Name = "cbxAppDefaultTwo";
            this.cbxAppDefaultTwo.Size = new System.Drawing.Size(83, 16);
            this.cbxAppDefaultTwo.TabIndex = 5;
            this.cbxAppDefaultTwo.Text = "设置为默认";
            this.cbxAppDefaultTwo.UseVisualStyleBackColor = true;
            // 
            // cbxAppDefaultOne
            // 
            this.cbxAppDefaultOne.AutoSize = true;
            this.cbxAppDefaultOne.Checked = true;
            this.cbxAppDefaultOne.Location = new System.Drawing.Point(543, 92);
            this.cbxAppDefaultOne.Name = "cbxAppDefaultOne";
            this.cbxAppDefaultOne.Size = new System.Drawing.Size(83, 16);
            this.cbxAppDefaultOne.TabIndex = 5;
            this.cbxAppDefaultOne.TabStop = true;
            this.cbxAppDefaultOne.Text = "设置为默认";
            this.cbxAppDefaultOne.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "<2>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "<1>";
            // 
            // tbxDefaultUrlTwo
            // 
            this.tbxDefaultUrlTwo.Location = new System.Drawing.Point(138, 114);
            this.tbxDefaultUrlTwo.Name = "tbxDefaultUrlTwo";
            this.tbxDefaultUrlTwo.Size = new System.Drawing.Size(398, 21);
            this.tbxDefaultUrlTwo.TabIndex = 3;
            // 
            // tbxDefaultUrlOne
            // 
            this.tbxDefaultUrlOne.Location = new System.Drawing.Point(138, 87);
            this.tbxDefaultUrlOne.Name = "tbxDefaultUrlOne";
            this.tbxDefaultUrlOne.Size = new System.Drawing.Size(398, 21);
            this.tbxDefaultUrlOne.TabIndex = 3;
            // 
            // tbxAppSecret
            // 
            this.tbxAppSecret.Location = new System.Drawing.Point(117, 59);
            this.tbxAppSecret.Name = "tbxAppSecret";
            this.tbxAppSecret.Size = new System.Drawing.Size(419, 21);
            this.tbxAppSecret.TabIndex = 3;
            // 
            // tbxAppID
            // 
            this.tbxAppID.Location = new System.Drawing.Point(117, 31);
            this.tbxAppID.Name = "tbxAppID";
            this.tbxAppID.Size = new System.Drawing.Size(419, 21);
            this.tbxAppID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "DefaultUrl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appsecret:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppID:";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(419, 201);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取  消";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(225, 201);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "保  存";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // AppModelConfigEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 262);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gb_Account);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppModelConfigEdit";
            this.Text = "添  加";
            this.gb_Account.ResumeLayout(false);
            this.gb_Account.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Account;
        private System.Windows.Forms.RadioButton cbxAppDefaultTwo;
        private System.Windows.Forms.RadioButton cbxAppDefaultOne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDefaultUrlTwo;
        private System.Windows.Forms.TextBox tbxDefaultUrlOne;
        private System.Windows.Forms.TextBox tbxAppSecret;
        private System.Windows.Forms.TextBox tbxAppID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
    }
}