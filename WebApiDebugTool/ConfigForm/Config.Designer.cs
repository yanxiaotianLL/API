namespace WebApiDebugTool
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.tbcContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgbWebApi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tbcContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbWebApi)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcContainer
            // 
            this.tbcContainer.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbcContainer.Controls.Add(this.tabPage1);
            this.tbcContainer.Controls.Add(this.tabPage2);
            this.tbcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcContainer.Location = new System.Drawing.Point(0, 0);
            this.tbcContainer.Name = "tbcContainer";
            this.tbcContainer.Padding = new System.Drawing.Point(6, 6);
            this.tbcContainer.SelectedIndex = 0;
            this.tbcContainer.Size = new System.Drawing.Size(762, 405);
            this.tbcContainer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgbWebApi);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WebApi配置列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添  加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgbWebApi
            // 
            this.dgbWebApi.AllowUserToAddRows = false;
            this.dgbWebApi.AllowUserToDeleteRows = false;
            this.dgbWebApi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbWebApi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbWebApi.Location = new System.Drawing.Point(3, 3);
            this.dgbWebApi.Name = "dgbWebApi";
            this.dgbWebApi.ReadOnly = true;
            this.dgbWebApi.RowTemplate.Height = 23;
            this.dgbWebApi.Size = new System.Drawing.Size(748, 364);
            this.dgbWebApi.TabIndex = 0;
            this.dgbWebApi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新系统配置列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "添  加";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 405);
            this.Controls.Add(this.tbcContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配  置";
            this.Load += new System.EventHandler(this.Config_Load);
            this.tbcContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbWebApi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgbWebApi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}