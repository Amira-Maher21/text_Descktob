namespace test1.Form
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.جد = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerIsActive = new System.Windows.Forms.CheckBox();
            this.FirstPerioudBalance = new DevExpress.XtraEditors.TextEdit();
            this.CustomerAddress = new DevExpress.XtraEditors.TextEdit();
            this.CustomerFlag = new DevExpress.XtraEditors.TextEdit();
            this.CustomerPhone2 = new DevExpress.XtraEditors.TextEdit();
            this.CustomerNotes = new DevExpress.XtraEditors.TextEdit();
            this.CustomerPhone1 = new DevExpress.XtraEditors.TextEdit();
            this.CustomerEmail = new DevExpress.XtraEditors.TextEdit();
            this.CustomerName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPerioudBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerFlag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhone2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.جد,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1082, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // جد
            // 
            this.جد.Caption = "barButtonItem1";
            this.جد.Id = 1;
            this.جد.Name = "جد";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "جديد";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "حفظ";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "اغلاق";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 609);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1082, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.CustomerIsActive);
            this.layoutControl1.Controls.Add(this.FirstPerioudBalance);
            this.layoutControl1.Controls.Add(this.CustomerAddress);
            this.layoutControl1.Controls.Add(this.CustomerFlag);
            this.layoutControl1.Controls.Add(this.CustomerPhone2);
            this.layoutControl1.Controls.Add(this.CustomerNotes);
            this.layoutControl1.Controls.Add(this.CustomerPhone1);
            this.layoutControl1.Controls.Add(this.CustomerEmail);
            this.layoutControl1.Controls.Add(this.CustomerName);
            this.layoutControl1.Location = new System.Drawing.Point(9, 145);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1072, 461);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 132);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1048, 307);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // CustomerIsActive
            // 
            this.CustomerIsActive.Location = new System.Drawing.Point(12, 108);
            this.CustomerIsActive.Name = "CustomerIsActive";
            this.CustomerIsActive.Size = new System.Drawing.Size(1048, 20);
            this.CustomerIsActive.TabIndex = 11;
            this.CustomerIsActive.Text = "فعال";
            this.CustomerIsActive.UseVisualStyleBackColor = true;
            // 
            // FirstPerioudBalance
            // 
            this.FirstPerioudBalance.Location = new System.Drawing.Point(12, 84);
            this.FirstPerioudBalance.MenuManager = this.ribbon;
            this.FirstPerioudBalance.Name = "FirstPerioudBalance";
            this.FirstPerioudBalance.Size = new System.Drawing.Size(417, 20);
            this.FirstPerioudBalance.StyleController = this.layoutControl1;
            this.FirstPerioudBalance.TabIndex = 3;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Location = new System.Drawing.Point(538, 84);
            this.CustomerAddress.MenuManager = this.ribbon;
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(417, 20);
            this.CustomerAddress.StyleController = this.layoutControl1;
            this.CustomerAddress.TabIndex = 4;
            // 
            // CustomerFlag
            // 
            this.CustomerFlag.Location = new System.Drawing.Point(12, 60);
            this.CustomerFlag.MenuManager = this.ribbon;
            this.CustomerFlag.Name = "CustomerFlag";
            this.CustomerFlag.Size = new System.Drawing.Size(417, 20);
            this.CustomerFlag.StyleController = this.layoutControl1;
            this.CustomerFlag.TabIndex = 5;
            // 
            // CustomerPhone2
            // 
            this.CustomerPhone2.Location = new System.Drawing.Point(538, 60);
            this.CustomerPhone2.MenuManager = this.ribbon;
            this.CustomerPhone2.Name = "CustomerPhone2";
            this.CustomerPhone2.Size = new System.Drawing.Size(417, 20);
            this.CustomerPhone2.StyleController = this.layoutControl1;
            this.CustomerPhone2.TabIndex = 6;
            // 
            // CustomerNotes
            // 
            this.CustomerNotes.Location = new System.Drawing.Point(12, 36);
            this.CustomerNotes.MenuManager = this.ribbon;
            this.CustomerNotes.Name = "CustomerNotes";
            this.CustomerNotes.Size = new System.Drawing.Size(417, 20);
            this.CustomerNotes.StyleController = this.layoutControl1;
            this.CustomerNotes.TabIndex = 7;
            // 
            // CustomerPhone1
            // 
            this.CustomerPhone1.Location = new System.Drawing.Point(538, 36);
            this.CustomerPhone1.MenuManager = this.ribbon;
            this.CustomerPhone1.Name = "CustomerPhone1";
            this.CustomerPhone1.Size = new System.Drawing.Size(417, 20);
            this.CustomerPhone1.StyleController = this.layoutControl1;
            this.CustomerPhone1.TabIndex = 8;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(12, 12);
            this.CustomerEmail.MenuManager = this.ribbon;
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(417, 20);
            this.CustomerEmail.StyleController = this.layoutControl1;
            this.CustomerEmail.TabIndex = 9;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(538, 12);
            this.CustomerName.MenuManager = this.ribbon;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(417, 20);
            this.CustomerName.StyleController = this.layoutControl1;
            this.CustomerName.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1072, 461);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CustomerName;
            this.layoutControlItem1.Location = new System.Drawing.Point(526, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem1.Text = "اسم العميل";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(102, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 431);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1052, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CustomerEmail;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem2.Text = "Email";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CustomerPhone1;
            this.layoutControlItem3.Location = new System.Drawing.Point(526, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem3.Text = "رقم التليفون 1";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CustomerNotes;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem4.Text = "Notes";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CustomerPhone2;
            this.layoutControlItem5.Location = new System.Drawing.Point(526, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem5.Text = "رقم التليفون 2";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.CustomerFlag;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem6.Text = "Flag";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.CustomerAddress;
            this.layoutControlItem7.Location = new System.Drawing.Point(526, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem7.Text = "عنوان العميل";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.FirstPerioudBalance;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(526, 24);
            this.layoutControlItem8.Text = "(FirstPerioudBalance)";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.CustomerIsActive;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(1052, 24);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.gridControl1;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(1052, 311);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 640);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Customer";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPerioudBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerFlag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhone2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem جد;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit FirstPerioudBalance;
        private DevExpress.XtraEditors.TextEdit CustomerAddress;
        private DevExpress.XtraEditors.TextEdit CustomerFlag;
        private DevExpress.XtraEditors.TextEdit CustomerPhone2;
        private DevExpress.XtraEditors.TextEdit CustomerNotes;
        private DevExpress.XtraEditors.TextEdit CustomerPhone1;
        private DevExpress.XtraEditors.TextEdit CustomerEmail;
        private DevExpress.XtraEditors.TextEdit CustomerName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.CheckBox CustomerIsActive;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}