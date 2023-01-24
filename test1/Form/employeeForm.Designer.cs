namespace test1.Form
{
    partial class employeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
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
            this.EmployeeIsActive = new System.Windows.Forms.CheckBox();
            this.EmployeeAddress = new DevExpress.XtraEditors.TextEdit();
            this.EmployeePhone = new DevExpress.XtraEditors.TextEdit();
            this.EmployeeSalary = new DevExpress.XtraEditors.TextEdit();
            this.UserNameLog = new DevExpress.XtraEditors.TextEdit();
            this.EmployeeName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.EmployeeName1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.EmployeeSalary11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.EmployeeAddress11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.EmployeePhone11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.UserNameLog11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.JobId = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalary11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAddress11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePhone11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameLog11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1032, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "جديد";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "حفظ";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "اغلاق";
            this.barButtonItem3.Id = 3;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 607);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1032, 31);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.JobId);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.EmployeeIsActive);
            this.layoutControl1.Controls.Add(this.EmployeeAddress);
            this.layoutControl1.Controls.Add(this.EmployeePhone);
            this.layoutControl1.Controls.Add(this.EmployeeSalary);
            this.layoutControl1.Controls.Add(this.UserNameLog);
            this.layoutControl1.Controls.Add(this.EmployeeName);
            this.layoutControl1.Location = new System.Drawing.Point(8, 145);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1028, 463);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1004, 357);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // EmployeeIsActive
            // 
            this.EmployeeIsActive.Location = new System.Drawing.Point(12, 60);
            this.EmployeeIsActive.Name = "EmployeeIsActive";
            this.EmployeeIsActive.Size = new System.Drawing.Size(248, 20);
            this.EmployeeIsActive.TabIndex = 3;
            this.EmployeeIsActive.Text = "فعال";
            this.EmployeeIsActive.UseVisualStyleBackColor = true;
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.Location = new System.Drawing.Point(516, 36);
            this.EmployeeAddress.MenuManager = this.ribbon;
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.Size = new System.Drawing.Size(423, 20);
            this.EmployeeAddress.StyleController = this.layoutControl1;
            this.EmployeeAddress.TabIndex = 3;
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.Location = new System.Drawing.Point(12, 36);
            this.EmployeePhone.MenuManager = this.ribbon;
            this.EmployeePhone.Name = "EmployeePhone";
            this.EmployeePhone.Size = new System.Drawing.Size(423, 20);
            this.EmployeePhone.StyleController = this.layoutControl1;
            this.EmployeePhone.TabIndex = 4;
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.Location = new System.Drawing.Point(516, 60);
            this.EmployeeSalary.MenuManager = this.ribbon;
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.Size = new System.Drawing.Size(423, 20);
            this.EmployeeSalary.StyleController = this.layoutControl1;
            this.EmployeeSalary.TabIndex = 3;
            // 
            // UserNameLog
            // 
            this.UserNameLog.Location = new System.Drawing.Point(264, 60);
            this.UserNameLog.MenuManager = this.ribbon;
            this.UserNameLog.Name = "UserNameLog";
            this.UserNameLog.Size = new System.Drawing.Size(171, 20);
            this.UserNameLog.StyleController = this.layoutControl1;
            this.UserNameLog.TabIndex = 4;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(516, 12);
            this.EmployeeName.MenuManager = this.ribbon;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(423, 20);
            this.EmployeeName.StyleController = this.layoutControl1;
            this.EmployeeName.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.EmployeeName1,
            this.emptySpaceItem1,
            this.EmployeeSalary11,
            this.EmployeeAddress11,
            this.EmployeePhone11,
            this.UserNameLog11,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1028, 463);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // EmployeeName1
            // 
            this.EmployeeName1.Control = this.EmployeeName;
            this.EmployeeName1.Location = new System.Drawing.Point(504, 0);
            this.EmployeeName1.Name = "EmployeeName1";
            this.EmployeeName1.Size = new System.Drawing.Size(504, 24);
            this.EmployeeName1.Text = "اسم الموظف";
            this.EmployeeName1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 433);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1008, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // EmployeeSalary11
            // 
            this.EmployeeSalary11.Control = this.EmployeeSalary;
            this.EmployeeSalary11.Location = new System.Drawing.Point(504, 48);
            this.EmployeeSalary11.Name = "EmployeeSalary11";
            this.EmployeeSalary11.Size = new System.Drawing.Size(504, 24);
            this.EmployeeSalary11.Text = "المرتب";
            this.EmployeeSalary11.TextSize = new System.Drawing.Size(74, 13);
            // 
            // EmployeeAddress11
            // 
            this.EmployeeAddress11.Control = this.EmployeeAddress;
            this.EmployeeAddress11.Location = new System.Drawing.Point(504, 24);
            this.EmployeeAddress11.Name = "EmployeeAddress11";
            this.EmployeeAddress11.Size = new System.Drawing.Size(504, 24);
            this.EmployeeAddress11.Text = "عنوان الموظف";
            this.EmployeeAddress11.TextSize = new System.Drawing.Size(74, 13);
            this.EmployeeAddress11.TrimClientAreaToControl = false;
            // 
            // EmployeePhone11
            // 
            this.EmployeePhone11.Control = this.EmployeePhone;
            this.EmployeePhone11.Location = new System.Drawing.Point(0, 24);
            this.EmployeePhone11.Name = "EmployeePhone11";
            this.EmployeePhone11.Size = new System.Drawing.Size(504, 24);
            this.EmployeePhone11.Text = "رقم التليفون";
            this.EmployeePhone11.TextSize = new System.Drawing.Size(74, 13);
            // 
            // UserNameLog11
            // 
            this.UserNameLog11.Control = this.UserNameLog;
            this.UserNameLog11.Location = new System.Drawing.Point(252, 48);
            this.UserNameLog11.Name = "UserNameLog11";
            this.UserNameLog11.Size = new System.Drawing.Size(252, 24);
            this.UserNameLog11.Text = "اسم المستخدم";
            this.UserNameLog11.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.EmployeeIsActive;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(252, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1008, 361);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // JobId
            // 
            this.JobId.Location = new System.Drawing.Point(12, 12);
            this.JobId.MenuManager = this.ribbon;
            this.JobId.Name = "JobId";
            this.JobId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.JobId.Properties.PopupView = this.searchLookUpEdit1View;
            this.JobId.Size = new System.Drawing.Size(423, 20);
            this.JobId.StyleController = this.layoutControl1;
            this.JobId.TabIndex = 6;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.JobId;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(504, 24);
            this.layoutControlItem2.Text = "الوظيفه";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 638);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "employeeForm";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "employeeForm";
            this.Load += new System.EventHandler(this.employeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalary11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAddress11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePhone11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameLog11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.TextEdit EmployeeSalary;
        private DevExpress.XtraEditors.TextEdit UserNameLog;
        private DevExpress.XtraEditors.TextEdit EmployeeName;
        private DevExpress.XtraLayout.LayoutControlItem EmployeeName1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem UserNameLog11;
        private DevExpress.XtraLayout.LayoutControlItem EmployeeSalary11;
        private System.Windows.Forms.CheckBox EmployeeIsActive;
        private DevExpress.XtraEditors.TextEdit EmployeeAddress;
        private DevExpress.XtraEditors.TextEdit EmployeePhone;
        private DevExpress.XtraLayout.LayoutControlItem EmployeePhone11;
        private DevExpress.XtraLayout.LayoutControlItem EmployeeAddress11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.SearchLookUpEdit JobId;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}