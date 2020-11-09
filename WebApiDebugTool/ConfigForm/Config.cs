using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FS.Common;
using WebApiDebugTool.Model;

namespace WebApiDebugTool
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 提交操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 取消操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            //初始化数据
            WebApiToolConfigModel models = new WebApiToolConfigModel();
            
            #region MyRegion
           
            models.AppConfigModels = new List<AppToolConfigModel>
            {
                new AppToolConfigModel
                {
                     ID = 1,
                     AppId = "NetworkApp",
                     AppSecret = "dc79116859df79db9c7c77ed923a3703",
                     DefaultUrls = "http://10.0.13.147:8010/API/{Controller}/{Action}",
                     IsChecked = true
                }
            };
            models.NewSystemConfigModels = new List<NewSystemAppToolConfigModel>
            {
                new NewSystemAppToolConfigModel
                {
                     ID = 1,
                     AppId = "NetworkApp",
                     AppSecret = "dc79116859df79db9c7c77ed923a3703",
                     DefaultUrls = "http://10.0.13.147:8010/API/{Controller}/{Action}",
                     IsChecked = true,
                     IsUseToken = false
                },
                new NewSystemAppToolConfigModel
                {
                     ID = 2,
                     AppId = "NetworkApp",
                     AppSecret = "dc79116859df79db9c7c77ed923a3703",
                     DefaultUrls = "http://10.0.13.147:8010/API/{Controller}/{Action}",
                     IsChecked = true,
                     IsUseToken = false
                }
            };

            SerializeHelper.Save(models, @"D:\vm\WebApiDebugTool.xml"); 
            
            #endregion
            //models = WebApiDebugTool.Configs.FSGlobalConfiguration.Configuration;
            dgbWebApi.DataSource = models.AppConfigModels;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
