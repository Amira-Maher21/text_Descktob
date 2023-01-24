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
    public partial class CustomerAccForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {


        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }
        public CustomerAccForm()
        {
            InitializeComponent();
        }

        private void CustomerAccForm_Load(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            CustomerId.EditValue = null;
            InvoiceId.EditValue = null;
            InvoiceNetValue.EditValue = null;
           

            code = 0;
            IsExist = false;
            IsNew = true;

            var CustomerAccount = dataContext.CustomerAccounts.ToList();
            gridControl1.DataSource = CustomerAccount;

            InvoiceId.Properties.DataSource = dataContext.InvoiceMasters.ToList();
            CustomerId.Properties.DataSource = dataContext.Customers.ToList();
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
                var z = dataContext.CustomerAccounts.Where(member => member.SuppliersAccountId == code).FirstOrDefault();

                z.CustomerId = Convert.ToInt32(CustomerId);
                z.InvoiceId = Convert.ToInt64(InvoiceId);
                z.InvoiceNetValue = Convert.ToDecimal(InvoiceNetValue);
                
                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                clear();

            }
            else if (IsNew)
            {
                try
                {
                    CustomerAccount customerAccount=new CustomerAccount ()
                    {
                     CustomerId = Convert.ToInt32(CustomerId),
                     InvoiceId = Convert.ToInt64(InvoiceId),
                     InvoiceNetValue = Convert.ToDecimal(InvoiceNetValue),

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
    }
}