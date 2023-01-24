using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using test1.Database;

namespace test1.Form
{
    public partial class StoresForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        

        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }


        public StoresForm()
        {
            InitializeComponent();
        }

        private void StoresForm_Load(object sender, EventArgs e)
        {
            var stores = dataContext.Stores.ToList();
            gridControl1.DataSource = stores;
        }
        private void clear()
        {
            StoreName.Text = "";
            StoreAddress.Text = "";
            StoreNotes.Text = "";
            StoreIsActive.Checked = true ;

            code = 0;
            IsExist = false;
            IsNew = true;

            var stores = dataContext.Stores.ToList();
            gridControl1.DataSource = stores;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            clear();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }




        private void InsertOrUpdate()
        {
            if (!dxValidationProvider1.Validate())
            {
                return;
            }
            if (IsExist)
            {
                var z = dataContext.Stores.Where(member => member.StoreId == code).FirstOrDefault();
                z.StoreName = StoreName.Text;
                z.StoreNotes = StoreNotes.Text;
                z.StoreAddress = StoreAddress.Text;
                z.StoreIsActive = Convert.ToBoolean(StoreIsActive);

                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                clear();

            }
            else if (IsNew)
            {
                try
                {
                    Store store= new Store()
                    {

                    StoreName = StoreName.Text,
                    StoreNotes = StoreNotes.Text,
                    StoreAddress = StoreAddress.Text,
                    StoreIsActive = Convert.ToBoolean(StoreIsActive),

                    };
                    dataContext.SubmitChanges();
                    MessageBox.Show("تم الحفظ");
                    clear();
                }
                catch
                {
                    MessageBox.Show("من فضلك البيانات المطلوبة", "خطا");
                }
            }

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            InsertOrUpdate();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            code = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StoreId"));
            var z = dataContext.Stores.Where(member => member.StoreId == code).FirstOrDefault();

            StoreName.Text= z.StoreName;
            StoreNotes.Text = z.StoreNotes ;
            StoreAddress.Text= z.StoreAddress;
             StoreIsActive.Checked=  Convert.ToBoolean(z.StoreIsActive);

            IsExist = true;
            IsNew = false;
        }
    }
}