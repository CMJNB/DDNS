namespace DDNS
{
    partial class DDNS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDNS));
            this.当前IP = new System.Windows.Forms.Label();
            this.获取 = new System.Windows.Forms.Button();
            this.公网ip = new System.Windows.Forms.TextBox();
            this.接口 = new System.Windows.Forms.Label();
            this.接口地址 = new System.Windows.Forms.TextBox();
            this.频率 = new System.Windows.Forms.Label();
            this.开始 = new System.Windows.Forms.Button();
            this.错误提示 = new System.Windows.Forms.ErrorProvider(this.components);
            this.滑动条分 = new System.Windows.Forms.TrackBar();
            this.状态信息 = new System.Windows.Forms.TextBox();
            this.域名地址 = new System.Windows.Forms.TextBox();
            this.密钥信息 = new System.Windows.Forms.TextBox();
            this.域名 = new System.Windows.Forms.Label();
            this.密钥 = new System.Windows.Forms.Label();
            this.状态 = new System.Windows.Forms.Label();
            this.滑动条秒 = new System.Windows.Forms.TrackBar();
            this.清除 = new System.Windows.Forms.Button();
            this.底部状态栏 = new System.Windows.Forms.StatusStrip();
            this.时间栏 = new System.Windows.Forms.ToolStripStatusLabel();
            this.时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.频率栏 = new System.Windows.Forms.ToolStripStatusLabel();
            this.频率值 = new System.Windows.Forms.ToolStripStatusLabel();
            this.发送倒计时 = new System.Windows.Forms.ToolStripProgressBar();
            this.托盘 = new System.Windows.Forms.NotifyIcon(this.components);
            this.频率时间 = new System.Windows.Forms.Timer(this.components);
            this.托盘时间 = new System.Windows.Forms.Timer(this.components);
            this.打开日志 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.错误提示)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.滑动条分)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.滑动条秒)).BeginInit();
            this.底部状态栏.SuspendLayout();
            this.SuspendLayout();
            // 
            // 当前IP
            // 
            resources.ApplyResources(this.当前IP, "当前IP");
            this.错误提示.SetError(this.当前IP, resources.GetString("当前IP.Error"));
            this.错误提示.SetIconAlignment(this.当前IP, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("当前IP.IconAlignment"))));
            this.错误提示.SetIconPadding(this.当前IP, ((int)(resources.GetObject("当前IP.IconPadding"))));
            this.当前IP.Name = "当前IP";
            // 
            // 获取
            // 
            resources.ApplyResources(this.获取, "获取");
            this.错误提示.SetError(this.获取, resources.GetString("获取.Error"));
            this.错误提示.SetIconAlignment(this.获取, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("获取.IconAlignment"))));
            this.错误提示.SetIconPadding(this.获取, ((int)(resources.GetObject("获取.IconPadding"))));
            this.获取.Name = "获取";
            this.获取.UseVisualStyleBackColor = true;
            this.获取.Click += new System.EventHandler(this.获取_Click);
            // 
            // 公网ip
            // 
            resources.ApplyResources(this.公网ip, "公网ip");
            this.错误提示.SetError(this.公网ip, resources.GetString("公网ip.Error"));
            this.错误提示.SetIconAlignment(this.公网ip, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("公网ip.IconAlignment"))));
            this.错误提示.SetIconPadding(this.公网ip, ((int)(resources.GetObject("公网ip.IconPadding"))));
            this.公网ip.Name = "公网ip";
            this.公网ip.ReadOnly = true;
            // 
            // 接口
            // 
            resources.ApplyResources(this.接口, "接口");
            this.错误提示.SetError(this.接口, resources.GetString("接口.Error"));
            this.错误提示.SetIconAlignment(this.接口, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("接口.IconAlignment"))));
            this.错误提示.SetIconPadding(this.接口, ((int)(resources.GetObject("接口.IconPadding"))));
            this.接口.Name = "接口";
            // 
            // 接口地址
            // 
            resources.ApplyResources(this.接口地址, "接口地址");
            this.接口地址.AllowDrop = true;
            this.错误提示.SetError(this.接口地址, resources.GetString("接口地址.Error"));
            this.错误提示.SetIconAlignment(this.接口地址, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("接口地址.IconAlignment"))));
            this.错误提示.SetIconPadding(this.接口地址, ((int)(resources.GetObject("接口地址.IconPadding"))));
            this.接口地址.Name = "接口地址";
            this.接口地址.TextChanged += new System.EventHandler(this.接口地址_TextChanged);
            // 
            // 频率
            // 
            resources.ApplyResources(this.频率, "频率");
            this.错误提示.SetError(this.频率, resources.GetString("频率.Error"));
            this.错误提示.SetIconAlignment(this.频率, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("频率.IconAlignment"))));
            this.错误提示.SetIconPadding(this.频率, ((int)(resources.GetObject("频率.IconPadding"))));
            this.频率.Name = "频率";
            // 
            // 开始
            // 
            resources.ApplyResources(this.开始, "开始");
            this.错误提示.SetError(this.开始, resources.GetString("开始.Error"));
            this.错误提示.SetIconAlignment(this.开始, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("开始.IconAlignment"))));
            this.错误提示.SetIconPadding(this.开始, ((int)(resources.GetObject("开始.IconPadding"))));
            this.开始.Name = "开始";
            this.开始.UseVisualStyleBackColor = true;
            this.开始.Click += new System.EventHandler(this.开始_Click);
            // 
            // 错误提示
            // 
            this.错误提示.ContainerControl = this;
            resources.ApplyResources(this.错误提示, "错误提示");
            // 
            // 滑动条分
            // 
            resources.ApplyResources(this.滑动条分, "滑动条分");
            this.错误提示.SetError(this.滑动条分, resources.GetString("滑动条分.Error"));
            this.错误提示.SetIconAlignment(this.滑动条分, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("滑动条分.IconAlignment"))));
            this.错误提示.SetIconPadding(this.滑动条分, ((int)(resources.GetObject("滑动条分.IconPadding"))));
            this.滑动条分.LargeChange = 1;
            this.滑动条分.Maximum = 12;
            this.滑动条分.Name = "滑动条分";
            this.滑动条分.Value = 12;
            this.滑动条分.Scroll += new System.EventHandler(this.滑动条分_Scroll);
            // 
            // 状态信息
            // 
            resources.ApplyResources(this.状态信息, "状态信息");
            this.错误提示.SetError(this.状态信息, resources.GetString("状态信息.Error"));
            this.错误提示.SetIconAlignment(this.状态信息, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("状态信息.IconAlignment"))));
            this.错误提示.SetIconPadding(this.状态信息, ((int)(resources.GetObject("状态信息.IconPadding"))));
            this.状态信息.Name = "状态信息";
            this.状态信息.ReadOnly = true;
            // 
            // 域名地址
            // 
            resources.ApplyResources(this.域名地址, "域名地址");
            this.域名地址.AllowDrop = true;
            this.错误提示.SetError(this.域名地址, resources.GetString("域名地址.Error"));
            this.错误提示.SetIconAlignment(this.域名地址, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("域名地址.IconAlignment"))));
            this.错误提示.SetIconPadding(this.域名地址, ((int)(resources.GetObject("域名地址.IconPadding"))));
            this.域名地址.Name = "域名地址";
            // 
            // 密钥信息
            // 
            resources.ApplyResources(this.密钥信息, "密钥信息");
            this.密钥信息.AllowDrop = true;
            this.错误提示.SetError(this.密钥信息, resources.GetString("密钥信息.Error"));
            this.错误提示.SetIconAlignment(this.密钥信息, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("密钥信息.IconAlignment"))));
            this.错误提示.SetIconPadding(this.密钥信息, ((int)(resources.GetObject("密钥信息.IconPadding"))));
            this.密钥信息.Name = "密钥信息";
            this.密钥信息.UseSystemPasswordChar = true;
            // 
            // 域名
            // 
            resources.ApplyResources(this.域名, "域名");
            this.错误提示.SetError(this.域名, resources.GetString("域名.Error"));
            this.错误提示.SetIconAlignment(this.域名, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("域名.IconAlignment"))));
            this.错误提示.SetIconPadding(this.域名, ((int)(resources.GetObject("域名.IconPadding"))));
            this.域名.Name = "域名";
            // 
            // 密钥
            // 
            resources.ApplyResources(this.密钥, "密钥");
            this.错误提示.SetError(this.密钥, resources.GetString("密钥.Error"));
            this.错误提示.SetIconAlignment(this.密钥, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("密钥.IconAlignment"))));
            this.错误提示.SetIconPadding(this.密钥, ((int)(resources.GetObject("密钥.IconPadding"))));
            this.密钥.Name = "密钥";
            // 
            // 状态
            // 
            resources.ApplyResources(this.状态, "状态");
            this.错误提示.SetError(this.状态, resources.GetString("状态.Error"));
            this.错误提示.SetIconAlignment(this.状态, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("状态.IconAlignment"))));
            this.错误提示.SetIconPadding(this.状态, ((int)(resources.GetObject("状态.IconPadding"))));
            this.状态.Name = "状态";
            // 
            // 滑动条秒
            // 
            resources.ApplyResources(this.滑动条秒, "滑动条秒");
            this.错误提示.SetError(this.滑动条秒, resources.GetString("滑动条秒.Error"));
            this.错误提示.SetIconAlignment(this.滑动条秒, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("滑动条秒.IconAlignment"))));
            this.错误提示.SetIconPadding(this.滑动条秒, ((int)(resources.GetObject("滑动条秒.IconPadding"))));
            this.滑动条秒.LargeChange = 1;
            this.滑动条秒.Maximum = 11;
            this.滑动条秒.Name = "滑动条秒";
            this.滑动条秒.Value = 11;
            this.滑动条秒.Scroll += new System.EventHandler(this.滑动条秒_Scroll);
            // 
            // 清除
            // 
            resources.ApplyResources(this.清除, "清除");
            this.错误提示.SetError(this.清除, resources.GetString("清除.Error"));
            this.错误提示.SetIconAlignment(this.清除, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("清除.IconAlignment"))));
            this.错误提示.SetIconPadding(this.清除, ((int)(resources.GetObject("清除.IconPadding"))));
            this.清除.Name = "清除";
            this.清除.UseVisualStyleBackColor = true;
            this.清除.Click += new System.EventHandler(this.清除_Click);
            // 
            // 底部状态栏
            // 
            resources.ApplyResources(this.底部状态栏, "底部状态栏");
            this.错误提示.SetError(this.底部状态栏, resources.GetString("底部状态栏.Error"));
            this.错误提示.SetIconAlignment(this.底部状态栏, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("底部状态栏.IconAlignment"))));
            this.错误提示.SetIconPadding(this.底部状态栏, ((int)(resources.GetObject("底部状态栏.IconPadding"))));
            this.底部状态栏.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.时间栏,
            this.时间,
            this.频率栏,
            this.频率值,
            this.发送倒计时});
            this.底部状态栏.Name = "底部状态栏";
            this.底部状态栏.SizingGrip = false;
            // 
            // 时间栏
            // 
            resources.ApplyResources(this.时间栏, "时间栏");
            this.时间栏.Name = "时间栏";
            // 
            // 时间
            // 
            resources.ApplyResources(this.时间, "时间");
            this.时间.Name = "时间";
            // 
            // 频率栏
            // 
            resources.ApplyResources(this.频率栏, "频率栏");
            this.频率栏.MergeIndex = 215;
            this.频率栏.Name = "频率栏";
            // 
            // 频率值
            // 
            resources.ApplyResources(this.频率值, "频率值");
            this.频率值.Name = "频率值";
            // 
            // 发送倒计时
            // 
            resources.ApplyResources(this.发送倒计时, "发送倒计时");
            this.发送倒计时.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.发送倒计时.MarqueeAnimationSpeed = 1;
            this.发送倒计时.Name = "发送倒计时";
            this.发送倒计时.Step = 1;
            this.发送倒计时.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // 托盘
            // 
            resources.ApplyResources(this.托盘, "托盘");
            this.托盘.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.托盘_MouseDoubleClick);
            // 
            // 频率时间
            // 
            this.频率时间.Interval = 3600000;
            this.频率时间.Tick += new System.EventHandler(this.频率时间_Tick);
            // 
            // 托盘时间
            // 
            this.托盘时间.Enabled = true;
            this.托盘时间.Interval = 1000;
            this.托盘时间.Tick += new System.EventHandler(this.托盘时间_Tick);
            // 
            // 打开日志
            // 
            resources.ApplyResources(this.打开日志, "打开日志");
            this.错误提示.SetError(this.打开日志, resources.GetString("打开日志.Error"));
            this.错误提示.SetIconAlignment(this.打开日志, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("打开日志.IconAlignment"))));
            this.错误提示.SetIconPadding(this.打开日志, ((int)(resources.GetObject("打开日志.IconPadding"))));
            this.打开日志.Name = "打开日志";
            this.打开日志.UseVisualStyleBackColor = true;
            this.打开日志.Click += new System.EventHandler(this.打开日志_Click);
            // 
            // DDNS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.打开日志);
            this.Controls.Add(this.底部状态栏);
            this.Controls.Add(this.清除);
            this.Controls.Add(this.滑动条秒);
            this.Controls.Add(this.状态);
            this.Controls.Add(this.密钥);
            this.Controls.Add(this.域名);
            this.Controls.Add(this.密钥信息);
            this.Controls.Add(this.域名地址);
            this.Controls.Add(this.状态信息);
            this.Controls.Add(this.滑动条分);
            this.Controls.Add(this.开始);
            this.Controls.Add(this.频率);
            this.Controls.Add(this.接口地址);
            this.Controls.Add(this.接口);
            this.Controls.Add(this.公网ip);
            this.Controls.Add(this.获取);
            this.Controls.Add(this.当前IP);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaximizeBox = false;
            this.Name = "DDNS";
            this.Load += new System.EventHandler(this.DDNS_Load);
            this.SizeChanged += new System.EventHandler(this.DDNS_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.错误提示)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.滑动条分)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.滑动条秒)).EndInit();
            this.底部状态栏.ResumeLayout(false);
            this.底部状态栏.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label 当前IP;
        private TextBox 公网ip;
        private Label 接口;
        private TextBox 接口地址;
        private Label 频率;
        private Button 开始;
        private ErrorProvider 错误提示;
        private TrackBar 滑动条分;
        private NotifyIcon 托盘;
        private TextBox 状态信息;
        private TextBox 密钥信息;
        private TextBox 域名地址;
        public Button 获取;
        private Label 密钥;
        private Label 域名;
        private Label 状态;
        private System.Windows.Forms.Timer 频率时间;
        private TrackBar 滑动条秒;
        public Button 清除;
        private StatusStrip 底部状态栏;
        private ToolStripStatusLabel 时间栏;
        private ToolStripStatusLabel 时间;
        private ToolStripStatusLabel 频率值;
        private ToolStripStatusLabel 频率栏;
        private System.Windows.Forms.Timer 托盘时间;
        public ToolStripProgressBar 发送倒计时;
        public Button 打开日志;
    }
}