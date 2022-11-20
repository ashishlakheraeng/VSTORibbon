
using System.Drawing;

namespace SampleExcelAddIn
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.Pane = this.Factory.CreateRibbonGroup();
            this.DownloadReports = this.Factory.CreateRibbonMenu();
            this.button1 = this.Factory.CreateRibbonButton();
            this.Report2 = this.Factory.CreateRibbonButton();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.SampleList = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.Pane.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // tab2
            // 
            this.tab2.Groups.Add(this.Pane);
            this.tab2.Label = "Report";
            this.tab2.Name = "tab2";
            // 
            // Pane
            // 
            this.Pane.Items.Add(this.DownloadReports);
            this.Pane.Label = "Pane";
            this.Pane.Name = "Pane";
            // 
            // DownloadReports
            // 
            this.DownloadReports.Image = ((System.Drawing.Image)(resources.GetObject("DownloadReports.Image")));
            this.DownloadReports.Items.Add(this.button1);
            this.DownloadReports.Items.Add(this.Report2);
            this.DownloadReports.Items.Add(this.menu1);
            this.DownloadReports.Label = "All Reports";
            this.DownloadReports.Name = "DownloadReports";
            this.DownloadReports.ScreenTip = "DownloadReports";
            this.DownloadReports.ShowImage = true;
            this.DownloadReports.SuperTip = "DownloadReports";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Label = "Report1";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // Report2
            // 
            this.Report2.Image = ((System.Drawing.Image)(resources.GetObject("Report2.Image")));
            this.Report2.Label = "Report2";
            this.Report2.Name = "Report2";
            this.Report2.ShowImage = true;
            this.Report2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Report2_Click);
            // 
            // menu1
            // 
            this.menu1.Items.Add(this.SampleList);
            this.menu1.Label = "menu1";
            this.menu1.Name = "menu1";
            this.menu1.ShowImage = true;
            // 
            // SampleList
            // 
            this.SampleList.Label = "SampleList";
            this.SampleList.Name = "SampleList";
            this.SampleList.ShowImage = true;
            this.SampleList.SuperTip = "SampleTip";
            this.SampleList.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tab2);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.Pane.ResumeLayout(false);
            this.Pane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Pane;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu DownloadReports;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Report2;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SampleList;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
