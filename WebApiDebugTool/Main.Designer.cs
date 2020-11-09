namespace WebApiDebugTool
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comRequestTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.requestTab = new System.Windows.Forms.TabControl();
            this.requestbody = new System.Windows.Forms.TabPage();
            this.txtRequestBody = new System.Windows.Forms.TextBox();
            this.requestHead = new System.Windows.Forms.TabPage();
            this.txtRequestHeader = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSignRequestBody = new System.Windows.Forms.TextBox();
            this.responseTab = new System.Windows.Forms.TabControl();
            this.responsebody = new System.Windows.Forms.TabPage();
            this.txtResponseBody = new System.Windows.Forms.TextBox();
            this.responseHead = new System.Windows.Forms.TabPage();
            this.txtResponseHeader = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.labtime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.原串测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbAppUrl = new System.Windows.Forms.ComboBox();
            this.cbxIsOriginal = new System.Windows.Forms.CheckBox();
            this.lblControler = new System.Windows.Forms.Label();
            this.txtController = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.txtIsOrgion = new System.Windows.Forms.TextBox();
            this.requestTab.SuspendLayout();
            this.requestbody.SuspendLayout();
            this.requestHead.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.responseTab.SuspendLayout();
            this.responsebody.SuspendLayout();
            this.responseHead.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "资源地址：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(687, 65);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "发 送";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // comRequestTypes
            // 
            this.comRequestTypes.FormattingEnabled = true;
            this.comRequestTypes.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.comRequestTypes.Location = new System.Drawing.Point(641, 33);
            this.comRequestTypes.Name = "comRequestTypes";
            this.comRequestTypes.Size = new System.Drawing.Size(121, 20);
            this.comRequestTypes.TabIndex = 4;
            this.comRequestTypes.Text = "Get";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "请求类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "请求：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "响应：";
            // 
            // requestTab
            // 
            this.requestTab.Controls.Add(this.requestbody);
            this.requestTab.Controls.Add(this.requestHead);
            this.requestTab.Controls.Add(this.tabPage1);
            this.requestTab.Location = new System.Drawing.Point(104, 122);
            this.requestTab.Name = "requestTab";
            this.requestTab.SelectedIndex = 0;
            this.requestTab.Size = new System.Drawing.Size(658, 125);
            this.requestTab.TabIndex = 8;
            // 
            // requestbody
            // 
            this.requestbody.Controls.Add(this.txtRequestBody);
            this.requestbody.Location = new System.Drawing.Point(4, 22);
            this.requestbody.Name = "requestbody";
            this.requestbody.Padding = new System.Windows.Forms.Padding(3);
            this.requestbody.Size = new System.Drawing.Size(650, 99);
            this.requestbody.TabIndex = 1;
            this.requestbody.Text = "请求体";
            this.requestbody.UseVisualStyleBackColor = true;
            // 
            // txtRequestBody
            // 
            this.txtRequestBody.Location = new System.Drawing.Point(0, 6);
            this.txtRequestBody.Multiline = true;
            this.txtRequestBody.Name = "txtRequestBody";
            this.txtRequestBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequestBody.Size = new System.Drawing.Size(644, 88);
            this.txtRequestBody.TabIndex = 0;
            // 
            // requestHead
            // 
            this.requestHead.Controls.Add(this.txtRequestHeader);
            this.requestHead.Location = new System.Drawing.Point(4, 22);
            this.requestHead.Name = "requestHead";
            this.requestHead.Padding = new System.Windows.Forms.Padding(3);
            this.requestHead.Size = new System.Drawing.Size(650, 99);
            this.requestHead.TabIndex = 0;
            this.requestHead.Text = "请求头";
            this.requestHead.UseVisualStyleBackColor = true;
            // 
            // txtRequestHeader
            // 
            this.txtRequestHeader.Location = new System.Drawing.Point(3, 6);
            this.txtRequestHeader.Multiline = true;
            this.txtRequestHeader.Name = "txtRequestHeader";
            this.txtRequestHeader.Size = new System.Drawing.Size(644, 90);
            this.txtRequestHeader.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSignRequestBody);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 99);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "签名请求体";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSignRequestBody
            // 
            this.txtSignRequestBody.Location = new System.Drawing.Point(7, 7);
            this.txtSignRequestBody.Multiline = true;
            this.txtSignRequestBody.Name = "txtSignRequestBody";
            this.txtSignRequestBody.Size = new System.Drawing.Size(640, 89);
            this.txtSignRequestBody.TabIndex = 0;
            // 
            // responseTab
            // 
            this.responseTab.Controls.Add(this.responsebody);
            this.responseTab.Controls.Add(this.responseHead);
            this.responseTab.Location = new System.Drawing.Point(105, 262);
            this.responseTab.Name = "responseTab";
            this.responseTab.SelectedIndex = 0;
            this.responseTab.Size = new System.Drawing.Size(653, 149);
            this.responseTab.TabIndex = 9;
            // 
            // responsebody
            // 
            this.responsebody.Controls.Add(this.txtResponseBody);
            this.responsebody.Location = new System.Drawing.Point(4, 22);
            this.responsebody.Name = "responsebody";
            this.responsebody.Padding = new System.Windows.Forms.Padding(3);
            this.responsebody.Size = new System.Drawing.Size(645, 123);
            this.responsebody.TabIndex = 1;
            this.responsebody.Text = "响应体";
            this.responsebody.UseVisualStyleBackColor = true;
            // 
            // txtResponseBody
            // 
            this.txtResponseBody.Location = new System.Drawing.Point(4, 6);
            this.txtResponseBody.Multiline = true;
            this.txtResponseBody.Name = "txtResponseBody";
            this.txtResponseBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponseBody.Size = new System.Drawing.Size(635, 114);
            this.txtResponseBody.TabIndex = 0;
            // 
            // responseHead
            // 
            this.responseHead.Controls.Add(this.txtResponseHeader);
            this.responseHead.Location = new System.Drawing.Point(4, 22);
            this.responseHead.Name = "responseHead";
            this.responseHead.Padding = new System.Windows.Forms.Padding(3);
            this.responseHead.Size = new System.Drawing.Size(645, 123);
            this.responseHead.TabIndex = 0;
            this.responseHead.Text = "响应头";
            this.responseHead.UseVisualStyleBackColor = true;
            // 
            // txtResponseHeader
            // 
            this.txtResponseHeader.Location = new System.Drawing.Point(7, 6);
            this.txtResponseHeader.Multiline = true;
            this.txtResponseHeader.Name = "txtResponseHeader";
            this.txtResponseHeader.Size = new System.Drawing.Size(635, 126);
            this.txtResponseHeader.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AppWebApiTool";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "响应时间：";
            // 
            // labtime
            // 
            this.labtime.AutoSize = true;
            this.labtime.Location = new System.Drawing.Point(108, 427);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(11, 12);
            this.labtime.TabIndex = 11;
            this.labtime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(156, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "（ms）";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.原串测试ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 原串测试ToolStripMenuItem
            // 
            this.原串测试ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("原串测试ToolStripMenuItem.Image")));
            this.原串测试ToolStripMenuItem.Name = "原串测试ToolStripMenuItem";
            this.原串测试ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.原串测试ToolStripMenuItem.Text = "原串测试";
            // 
            // cmbAppUrl
            // 
            this.cmbAppUrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppUrl.FormattingEnabled = true;
            this.cmbAppUrl.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbAppUrl.Location = new System.Drawing.Point(105, 31);
            this.cmbAppUrl.Name = "cmbAppUrl";
            this.cmbAppUrl.Size = new System.Drawing.Size(440, 20);
            this.cmbAppUrl.TabIndex = 14;
            // 
            // cbxIsOriginal
            // 
            this.cbxIsOriginal.AutoSize = true;
            this.cbxIsOriginal.Location = new System.Drawing.Point(554, 64);
            this.cbxIsOriginal.Name = "cbxIsOriginal";
            this.cbxIsOriginal.Size = new System.Drawing.Size(84, 16);
            this.cbxIsOriginal.TabIndex = 15;
            this.cbxIsOriginal.Text = "是否为原串";
            this.cbxIsOriginal.UseVisualStyleBackColor = true;
            this.cbxIsOriginal.CheckedChanged += new System.EventHandler(this.cbxIsOriginal_CheckedChanged);
            // 
            // lblControler
            // 
            this.lblControler.AutoSize = true;
            this.lblControler.Location = new System.Drawing.Point(13, 65);
            this.lblControler.Name = "lblControler";
            this.lblControler.Size = new System.Drawing.Size(83, 12);
            this.lblControler.TabIndex = 16;
            this.lblControler.Text = "Controller ：";
            // 
            // txtController
            // 
            this.txtController.Location = new System.Drawing.Point(105, 59);
            this.txtController.Name = "txtController";
            this.txtController.Size = new System.Drawing.Size(440, 21);
            this.txtController.TabIndex = 17;
            this.txtController.Text = "Collect";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(37, 87);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(59, 12);
            this.lblAction.TabIndex = 18;
            this.lblAction.Text = "Action ：";
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(104, 85);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(441, 21);
            this.txtAction.TabIndex = 19;
            this.txtAction.Text = "GiveTask";
            // 
            // txtIsOrgion
            // 
            this.txtIsOrgion.Location = new System.Drawing.Point(103, 32);
            this.txtIsOrgion.Name = "txtIsOrgion";
            this.txtIsOrgion.Size = new System.Drawing.Size(441, 21);
            this.txtIsOrgion.TabIndex = 20;
            this.txtIsOrgion.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 452);
            this.Controls.Add(this.txtIsOrgion);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.txtController);
            this.Controls.Add(this.lblControler);
            this.Controls.Add(this.cbxIsOriginal);
            this.Controls.Add(this.cmbAppUrl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.responseTab);
            this.Controls.Add(this.requestTab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comRequestTypes);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppWebApi测试工具";
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Main_Load);
            this.requestTab.ResumeLayout(false);
            this.requestbody.ResumeLayout(false);
            this.requestbody.PerformLayout();
            this.requestHead.ResumeLayout(false);
            this.requestHead.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.responseTab.ResumeLayout(false);
            this.responsebody.ResumeLayout(false);
            this.responsebody.PerformLayout();
            this.responseHead.ResumeLayout(false);
            this.responseHead.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comRequestTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl requestTab;
        private System.Windows.Forms.TabPage requestHead;
        private System.Windows.Forms.TabPage requestbody;
        private System.Windows.Forms.TabControl responseTab;
        private System.Windows.Forms.TabPage responseHead;
        private System.Windows.Forms.TabPage responsebody;
        private System.Windows.Forms.TextBox txtRequestHeader;
        private System.Windows.Forms.TextBox txtRequestBody;
        private System.Windows.Forms.TextBox txtResponseHeader;
        private System.Windows.Forms.TextBox txtResponseBody;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSignRequestBody;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 原串测试ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbAppUrl;
        private System.Windows.Forms.CheckBox cbxIsOriginal;
        private System.Windows.Forms.Label lblControler;
        private System.Windows.Forms.TextBox txtController;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.TextBox txtIsOrgion;
    }
}

