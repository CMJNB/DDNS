using NPOI.Util;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DDNS
{
    public partial class DDNS : Form
    {
        string strLogName = "";
        bool stop = true, stat = true,error=true;
        int mm = 3600000, ss = 55000;
        private CancellationTokenSource ddns_stop;
        private static readonly HttpClient HttpClient;

        public DDNS()
        {
            InitializeComponent();
        }

        private void DDNS_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.Hide();
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }

        private void Ip_Go()
        {
            /// 获取外网IP地址
            string strUrl = "http://ip-api.com/json/?fields=8192"; //获得IP的网址  
            Uri uri = new(strUrl);
            WebRequest wr = WebRequest.Create(uri);
            string all = "";
            try
            {
                Stream s = wr.GetResponse().GetResponseStream();
                StreamReader sr = new(s, Encoding.Default);
                all = sr.ReadToEnd(); //读取网站的数据  
            }
            catch (Exception)
            {
                this.Invoke(new Action(() => 公网ip.Text = "获取ip失败"));
            }
            Match match;
            string pattern = "(\\d+)\\.(\\d+)\\.(\\d+)\\.(\\d+)";
            match = Regex.Match(all, pattern, RegexOptions.IgnoreCase);
            this.Invoke(new Action(() => 公网ip.Text = match.ToString()));
            System.Diagnostics.Debug.Write(match.ToString());
        }

        private void 获取_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(state => Ip_Go());
        }

        private void Ddns_Go(CancellationToken ddns)
        {
            stop = false;
            System.Diagnostics.Debug.Write(接口地址.Text);
            this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 5));
            this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 10));
            System.Diagnostics.Debug.Write(ddns_stop.IsCancellationRequested + "@@@@");
            System.Diagnostics.Debug.Write(ddns.IsCancellationRequested + "@@@@");
            this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 15));
            try
            {
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 20)); 
                // 创建 Network Credential 类的空实例。
                NetworkCredential myCredentials = new(域名地址.Text, 密钥信息.Text);
                // 使用指定的 URL 创建一个 webrequest。
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 25));


                //using var client = new HttpClient();
                //string content = client.GetStringAsync("http://ip-api.com/json/?fields=8192");
                //Task.Result


                //System.Diagnostics.Debug.Write("?????" + content+ " ??????");

                WebRequest myWebRequest = WebRequest.Create(接口地址.Text);
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 30)); 
                myWebRequest.Credentials = myCredentials.GetCredential(new Uri(接口地址.Text), "");
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 50));
                Console.WriteLine("\n\n用户凭证:- 用户名 : {0} , 密码 : {1}", myCredentials.UserName, myCredentials.Password);
                // 发送请求并等待响应。
                Console.WriteLine("\n\n已发送对 Url 的请求。等待响应...请稍候...");
                WebResponse myWebResponse = myWebRequest.GetResponse();
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 60));
                // 处理响应。
                Console.WriteLine("\n成功收到回复");
                if (ddns.IsCancellationRequested)
                {
                    System.Diagnostics.Debug.Write("已暂停");
                    stop = true;
                    return;
                }
                // 释放响应对象的资源。
                StreamReader sr = new(myWebResponse.GetResponseStream(), Encoding.UTF8);
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 65));
                WriteLog(sr.ReadToEnd());
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 90));
                myWebResponse.Close();
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 95));
                this.Invoke(new Action(() => this.错误提示.Clear()));
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum ));
                stop = true;
            }
            catch (WebException)
            {
                if (ddns.IsCancellationRequested)
                {
                    System.Diagnostics.Debug.Write("已暂停");
                    stop = true;
                    return;
                }
                this.Invoke(new Action(() => this.错误提示.SetError(this.状态信息, "链接超时")));
                WriteLog("链接超时");
                stop = true;
                this.Invoke(new Action(() => 发送倒计时.Value = 0));
            }
            catch (Exception)
            {
                if (ddns.IsCancellationRequested)
                {
                    System.Diagnostics.Debug.Write("已暂停");
                    stop = true;
                    return;
                }
                this.Invoke(new Action(() => UI_End()));
                this.Invoke(new Action(() => this.错误提示.SetError(this.接口地址, "输入格式错误")));
                stop = true;
                this.Invoke(new Action(() => 发送倒计时.Value = 0));
                return;
            }
        }

        void UI_Stat()
        {
            开始.Text = "暂停";
            stat = false;
            频率时间.Enabled = true;
            发送倒计时.Enabled = true;
            滑动条秒.Enabled = false;
            滑动条分.Enabled = false;
            接口地址.ReadOnly = true;
            域名地址.ReadOnly = true;
            密钥信息.ReadOnly = true;
            if (!接口地址.Text.StartsWith("http://", true, null) && !接口地址.Text.StartsWith("https://", true, null))
            {
                接口地址.Text = "https://" + 接口地址.Text;
            }
            ThreadPool.QueueUserWorkItem(state => Error());
        }

        void UI_End()
        {
            开始.Text = 滑动条分.Value * 5 + "分" + 滑动条秒.Value * 5 + "秒/次";
            stat = true;
            频率时间.Enabled = false;
            发送倒计时.Enabled = false;
            滑动条秒.Enabled = true;
            滑动条分.Enabled = true;
            接口地址.ReadOnly = false;
            域名地址.ReadOnly = false;
            密钥信息.ReadOnly = false;
        }

        private void 开始_Click(object sender, EventArgs e)
        {
            if (stat)
            {
                UI_Stat();
                ddns_stop = new CancellationTokenSource();
            }
            else
            {
                UI_End();
                ddns_stop.Cancel();
                this.Invoke(new Action(() => 发送倒计时.Value = 0));
            }
        }

        private void 频率时间_Tick(object sender, EventArgs e)
        {
            if (stop)
            {
                ThreadPool.QueueUserWorkItem(state => Ddns_Go(ddns_stop.Token));
            }
        }

        private void 滑动条分_Scroll(object sender, EventArgs e)
        {
            int ss0 = ss;
            int ss1 = ss0;
            if (滑动条分.Value == 12)
            {
                ss = 0;
                滑动条秒.Enabled = false;
                频率值.Text = "60分/次";
                开始.Text = "60分/次";
            }
            else
            {
                ss = ss1;
                滑动条秒.Enabled = true;
                频率值.Text = 滑动条分.Value * 5 + "分" + 滑动条秒.Value * 5 + "秒/次";
                开始.Text = 滑动条分.Value * 5 + "分" + 滑动条秒.Value * 5 + "秒/次";
            }
            mm = 滑动条分.Value * 1000 * 5 * 60;
            频率时间.Interval = mm + ss < 1 ? 1 : mm + ss;
            发送倒计时.Maximum = 频率时间.Interval;
        }

        private void 滑动条秒_Scroll(object sender, EventArgs e)
        {
            ss = 滑动条秒.Value * 1000 * 5;
            开始.Text = 滑动条分.Value * 5 + "分" + 滑动条秒.Value * 5 + "秒/次";
            频率值.Text = 滑动条分.Value * 5 + "分" + 滑动条秒.Value * 5 + "秒/次";
            频率时间.Interval = mm + ss < 1 ? 1 : mm + ss;
            发送倒计时.Maximum = 频率时间.Interval;
        }

        private void 托盘_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        public void Error()
        {
            error = false;
            try
            {   
                Thread.Sleep(1000);
                WebRequest.Create(接口地址.Text);
                this.Invoke(new Action(() => this.错误提示.Clear()));
                error = true;
                return;
            }
            catch (Exception)
            {
                this.Invoke(new Action(() => UI_End()));
                this.Invoke(new Action(() => this.错误提示.SetError(this.接口地址, "输入格式错误")));
            }
            error = true;
        }

        private void 接口地址_TextChanged(object sender, EventArgs e)
        {
            if (error)
            {
                ThreadPool.QueueUserWorkItem(state => Error());
            }
        }

        public void WriteLog(string Action)
        {
            this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 70));
            try
            {
                string strLogPath = ".";
                strLogName = System.DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "-");
                if (!strLogPath.EndsWith("\\"))
                {
                    strLogPath += "\\";
                }
                strLogPath += "Log\\";
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 75));
                System.IO.Directory.CreateDirectory(strLogPath);               
                strLogName = strLogPath + strLogName + ".log";
                System.Diagnostics.Debug.Write(strLogName + "***");
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 80));
                ////如果文件不存在，会自动创建
                string strNote = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff");
                strNote += " : " + Action;
                System.IO.StreamWriter file = new(strLogName, true);
                file.WriteLine(strNote);
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 85));
                this.BeginInvoke((Action)(() =>
                {
                    状态信息.AppendText(strNote + Environment.NewLine + Environment.NewLine);
                    状态信息.ScrollToCaret();
                }));
                file.Close();
                file.Dispose();
                this.Invoke(new Action(() => 发送倒计时.Value = 发送倒计时.Maximum / 100 * 87));
            }
            catch //(FormatException ex)
            {
            }
        }

        private void 打开日志_Click(object sender, EventArgs e)
        {
            var newPath = ".\\Log";
            var psi = new System.Diagnostics.ProcessStartInfo()
            {
                FileName = newPath,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void 托盘时间_Tick(object sender, EventArgs e)
        {
            时间.Text = System.DateTime.Now.ToString("MM/dd HH:mm:ss");
        }

        private void DDNS_Load(object sender, EventArgs e)
        {
        }

        private void 清除_Click(object sender, EventArgs e)
        {
            状态信息.Clear();
            this.Invoke(new Action(() => this.错误提示.Clear()));
        }
    }
}
