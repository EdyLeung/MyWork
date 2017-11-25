namespace MyFunction
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.editBoxText = this.Factory.CreateRibbonEditBox();
            this.btnSearch = this.Factory.CreateRibbonButton();
            this.btnSearchWkb = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnOpenForm = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.box1.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "梁小铭";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.box1);
            this.group1.Label = "作业1：扩展方法+分两层";
            this.group1.Name = "group1";
            // 
            // box1
            // 
            this.box1.Items.Add(this.editBoxText);
            this.box1.Items.Add(this.btnSearch);
            this.box1.Items.Add(this.btnSearchWkb);
            this.box1.Name = "box1";
            // 
            // editBoxText
            // 
            this.editBoxText.Label = "表/薄名：";
            this.editBoxText.Name = "editBoxText";
            this.editBoxText.SizeString = "99999999999999999";
            this.editBoxText.SuperTip = "输入要定位的工作表名";
            this.editBoxText.Text = null;
            this.editBoxText.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBoxText_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Label = "搜表";
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSearch_Click);
            // 
            // btnSearchWkb
            // 
            this.btnSearchWkb.Label = "搜薄";
            this.btnSearchWkb.Name = "btnSearchWkb";
            this.btnSearchWkb.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSearchWkb_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnOpenForm);
            this.group2.Label = "作业2：网抓数据到E";
            this.group2.Name = "group2";
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnOpenForm.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenForm.Image")));
            this.btnOpenForm.Label = "OpenWinform";
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.ShowImage = true;
            this.btnOpenForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnOpenForm_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBoxText;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSearch;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSearchWkb;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOpenForm;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
