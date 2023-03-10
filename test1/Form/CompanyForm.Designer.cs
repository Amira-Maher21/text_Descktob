namespace test1.Form
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CompanyCommerceFileNumber = new DevExpress.XtraEditors.TextEdit();
            this.CompanyLogo = new DevExpress.XtraEditors.TextEdit();
            this.CompanyAddress = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CompanyIsActive = new System.Windows.Forms.CheckBox();
            this.CompanyPhone = new DevExpress.XtraEditors.TextEdit();
            this.CompanyTaxFileNumber = new DevExpress.XtraEditors.TextEdit();
            this.CompaneDesc = new DevExpress.XtraEditors.TextEdit();
            this.CompanyFax = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Comp = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyCommerceFileNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyTaxFileNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaneDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1036, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "جديد";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "حفظ";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "اغلاق";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 621);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1036, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CompanyCommerceFileNumber);
            this.layoutControl1.Controls.Add(this.CompanyLogo);
            this.layoutControl1.Controls.Add(this.CompanyAddress);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.CompanyIsActive);
            this.layoutControl1.Controls.Add(this.CompanyPhone);
            this.layoutControl1.Controls.Add(this.CompanyTaxFileNumber);
            this.layoutControl1.Controls.Add(this.CompaneDesc);
            this.layoutControl1.Controls.Add(this.CompanyFax);
            this.layoutControl1.Location = new System.Drawing.Point(1, 145);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1032, 476);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CompanyCommerceFileNumber
            // 
            this.CompanyCommerceFileNumber.Location = new System.Drawing.Point(12, 36);
            this.CompanyCommerceFileNumber.MenuManager = this.ribbon;
            this.CompanyCommerceFileNumber.Name = "CompanyCommerceFileNumber";
            this.CompanyCommerceFileNumber.Size = new System.Drawing.Size(411, 20);
            this.CompanyCommerceFileNumber.StyleController = this.layoutControl1;
            this.CompanyCommerceFileNumber.TabIndex = 12;
            // 
            // CompanyLogo
            // 
            this.CompanyLogo.Location = new System.Drawing.Point(12, 60);
            this.CompanyLogo.MenuManager = this.ribbon;
            this.CompanyLogo.Name = "CompanyLogo";
            this.CompanyLogo.Size = new System.Drawing.Size(411, 20);
            this.CompanyLogo.StyleController = this.layoutControl1;
            this.CompanyLogo.TabIndex = 11;
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.Location = new System.Drawing.Point(518, 60);
            this.CompanyAddress.MenuManager = this.ribbon;
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.Size = new System.Drawing.Size(411, 20);
            this.CompanyAddress.StyleController = this.layoutControl1;
            this.CompanyAddress.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 108);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1008, 344);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // CompanyIsActive
            // 
            this.CompanyIsActive.Location = new System.Drawing.Point(12, 84);
            this.CompanyIsActive.Name = "CompanyIsActive";
            this.CompanyIsActive.Size = new System.Drawing.Size(502, 20);
            this.CompanyIsActive.TabIndex = 3;
            this.CompanyIsActive.Text = "فعال";
            this.CompanyIsActive.UseVisualStyleBackColor = true;
            // 
            // CompanyPhone
            // 
            this.CompanyPhone.Location = new System.Drawing.Point(518, 84);
            this.CompanyPhone.MenuManager = this.ribbon;
            this.CompanyPhone.Name = "CompanyPhone";
            this.CompanyPhone.Size = new System.Drawing.Size(411, 20);
            this.CompanyPhone.StyleController = this.layoutControl1;
            this.CompanyPhone.TabIndex = 10;
            // 
            // CompanyTaxFileNumber
            // 
            this.CompanyTaxFileNumber.Location = new System.Drawing.Point(12, 12);
            this.CompanyTaxFileNumber.MenuManager = this.ribbon;
            this.CompanyTaxFileNumber.Name = "CompanyTaxFileNumber";
            this.CompanyTaxFileNumber.Size = new System.Drawing.Size(411, 20);
            this.CompanyTaxFileNumber.StyleController = this.layoutControl1;
            this.CompanyTaxFileNumber.TabIndex = 6;
            this.CompanyTaxFileNumber.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            // 
            // CompaneDesc
            // 
            this.CompaneDesc.Location = new System.Drawing.Point(518, 12);
            this.CompaneDesc.MenuManager = this.ribbon;
            this.CompaneDesc.Name = "CompaneDesc";
            this.CompaneDesc.Size = new System.Drawing.Size(411, 20);
            this.CompaneDesc.StyleController = this.layoutControl1;
            this.CompaneDesc.TabIndex = 5;
            this.CompaneDesc.EditValueChanged += new System.EventHandler(this.CompaneDesc_EditValueChanged);
            // 
            // CompanyFax
            // 
            this.CompanyFax.Location = new System.Drawing.Point(518, 36);
            this.CompanyFax.MenuManager = this.ribbon;
            this.CompanyFax.Name = "CompanyFax";
            this.CompanyFax.Size = new System.Drawing.Size(411, 20);
            this.CompanyFax.StyleController = this.layoutControl1;
            this.CompanyFax.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.Comp});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1032, 476);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 444);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1012, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.gridControl1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(1012, 348);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.CompanyIsActive;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CompaneDesc;
            this.layoutControlItem2.Location = new System.Drawing.Point(506, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem2.Text = "الشركه";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CompanyFax;
            this.layoutControlItem1.Location = new System.Drawing.Point(506, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem1.Text = "الفاكس";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CompanyLogo;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem5.Text = "شعار الشركه";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CompanyTaxFileNumber;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem3.Text = "رقم الملف الضريبي";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.CompanyCommerceFileNumber;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem6.Text = "رقم الملف التجاري";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CompanyAddress;
            this.layoutControlItem4.Location = new System.Drawing.Point(506, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(506, 24);
            this.layoutControlItem4.Text = "عنوان الشركه";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 13);
            // 
            // Comp
            // 
            this.Comp.Control = this.CompanyPhone;
            this.Comp.Location = new System.Drawing.Point(506, 72);
            this.Comp.Name = "Comp";
            this.Comp.Size = new System.Drawing.Size(506, 24);
            this.Comp.Text = "رقم التليفون";
            this.Comp.TextSize = new System.Drawing.Size(88, 13);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 652);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "CompanyForm";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CompanyForm";
            this.Load += new System.EventHandler(this.gridView1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyCommerceFileNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyTaxFileNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaneDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.CheckBox CompanyIsActive;
        private DevExpress.XtraEditors.TextEdit CompanyPhone;
        private DevExpress.XtraEditors.TextEdit CompanyTaxFileNumber;
        private DevExpress.XtraEditors.TextEdit CompaneDesc;
        private DevExpress.XtraEditors.TextEdit CompanyFax;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem Comp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit CompanyCommerceFileNumber;
        private DevExpress.XtraEditors.TextEdit CompanyLogo;
        private DevExpress.XtraEditors.TextEdit CompanyAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}