using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiDebugTool.Helper;

namespace WebApiDebugTool
{
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            txtRequestHeader.Text = string.Format(@"User-Agent: AppWebApiTools{0}bHost: localhost:1599{1}Content-Type: application/json", Environment.NewLine, Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtUrl = string.Empty;
            //判断是否为原串测试
            if (cbxIsOriginal.Checked)
            {
                txtUrl = txtIsOrgion.Text.Trim();
                txtIsOrgion.Focus();
            }
            else
            {
                txtUrl = cmbAppUrl.Text.Trim().ToString();
                cmbAppUrl.Focus();
                //设置当前appid等信息
                if (cmbAppUrl.SelectedIndex >= 0)
                {
                    int selectItemValue = Convert.ToInt32(cmbAppUrl.SelectedValue.ToString());
                    WebApiDebugTool.Configs.FSGlobalConfiguration.Configuration.CurrentAppConfigModel =
                        WebApiDebugTool.Configs.FSGlobalConfiguration.Configuration.AppConfigModels.Single(
                            s => s.ID == selectItemValue);
                }
            }
            if (string.IsNullOrEmpty(txtUrl.Trim()))
            {
                MessageBox.Show("资源地址不能为空");
            }
            else if (string.IsNullOrEmpty(txtRequestHeader.Text.Trim()))
            {
                requestTab.SelectedIndex = 0;
                txtRequestHeader.Focus();

                MessageBox.Show("请求头不能为空");
            }
            else if (string.IsNullOrEmpty(txtRequestBody.Text.Trim()) && comRequestTypes.SelectedItem.ToString().ToUpper() == "POST")
            {
                requestTab.SelectedIndex = 1;
                txtRequestBody.Focus();
                MessageBox.Show("请求体不能为空");
            }
            else
            {
                try
                {
                    Dictionary<string, KeyValuePair<string, IEnumerable<string>>> headers;
                    Stopwatch sw = new Stopwatch();
                    if (comRequestTypes.SelectedItem.ToString().ToUpper() == "GET")
                    {
                        string parmter = string.Empty;
                        string url = string.Empty;
                        //判断是否为原串测试
                        if (cbxIsOriginal.Checked)
                        {
                            url = txtUrl.Trim();
                        }
                        else
                        {
                            parmter = HttpParmpterHelper.CreateGetUrlAndParm(txtRequestBody.Text.Trim());
                            url = string.Format("{0}{1}/{2}", txtUrl.Trim(), txtController.Text.Trim(), txtAction.Text.Trim()) +parmter;
                            txtSignRequestBody.Text = url;
                        }
                       
                        sw.Start();
                        var result =HttpHelper.HttpGetString(url, GetHeaders(txtRequestHeader.Text.Trim()));
                        sw.Stop();
                        
                        txtResponseBody.Text = result;
                        labtime.Text = sw.ElapsedMilliseconds.ToString();

                    }
                    else
                    {
                        string paramter = string.Empty;
                        

                         //判断是否为原串测试
                        if (cbxIsOriginal.Checked)
                        {
                            paramter = txtRequestBody.Text.Trim();
                        }
                        else
                        {
                            paramter = HttpParmpterHelper.CreatePostParm(txtRequestBody.Text.Trim());
                            txtSignRequestBody.Text = paramter;
                            txtUrl = string.Format("{0}{1}/{2}", txtUrl.Trim(), txtController.Text.Trim(),
                                txtAction.Text.Trim());
                        }
                        sw.Start();
                        var result = HttpHelper.httpPost(txtUrl, paramter,
                            GetHeaders(txtRequestHeader.Text.Trim()));
                        sw.Stop();
                        txtResponseBody.Text = result;
                        labtime.Text = sw.ElapsedMilliseconds.ToString();
                    }
                    //if (headers != null && headers.Count > 0)
                    //{
                    //    foreach (var item in headers)
                    //    {
                    //        txtResponseHeader.Text += txtResponseHeader.Text + Environment.NewLine;
                    //        txtResponseHeader.Text += txtResponseHeader.Text + item.Key + ":" + item.Value;

                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    txtResponseBody.Text = string.Format(
                        "Source：{0}{1}Message：{2}{3}StackTrace:{4}{5}TargetSite:{6}{7}", ex.Source, Environment.NewLine,
                        ex.Message, Environment.NewLine, ex.StackTrace, Environment.NewLine, ex.TargetSite,
                        Environment.NewLine);
                    //MessageBox.Show("请求过程中发生异常：" + ex.Message);
                }
            }
        }

        private Dictionary<string, string> GetHeaders(string strHeader)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(strHeader.Trim()))
            {
                string[] array = strHeader.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (var item in array)
                {
                    string[] head = item.Split(':');
                    headers.Add(head[0], head[1]);
                }
            }
            
            return headers;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;  //显示在系统任务栏
            this.WindowState = FormWindowState.Normal;  //还原窗体
            notifyIcon1.Visible = false;  //托盘图标隐藏
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏
                notifyIcon1.Visible = true;  //托盘图标可见
            }
        }
       

        private void Main_Load(object sender, EventArgs e)
        {
            cmbAppUrl.DataSource = WebApiDebugTool.Configs.FSGlobalConfiguration.Configuration.AppConfigModels.OrderBy(o=>o.IsChecked).ToList();
            cmbAppUrl.DisplayMember = "DefaultUrls";
            cmbAppUrl.ValueMember = "ID";
        }

        private void cbxIsOriginal_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxIsOriginal.Checked)
            {
                lblAction.Visible = false;
                lblControler.Visible = false;
                cmbAppUrl.Visible = false;
                txtController.Visible = false;
                txtAction.Visible = false;
                txtIsOrgion.Visible = true;
            }
            else
            {
                lblAction.Visible = true;
                lblControler.Visible = true;
                cmbAppUrl.Visible = true;
                txtController.Visible = true;
                txtAction.Visible = true;
                txtIsOrgion.Visible = false;
            }
        }
    }
}
