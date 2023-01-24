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
    
    public partial class Customer : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }


        private void clear()
        {
            CustomerName.Text = "";
            CustomerPhone1.Text = "";
            CustomerPhone2.Text = "";
            CustomerAddress.Text = "";
            CustomerEmail.Text = "";
            CustomerNotes.Text = "";
            CustomerFlag.EditValue = null;
            FirstPerioudBalance.EditValue = null;
            CustomerIsActive.Checked = true;

            code = 0;
            IsExist = false;
            IsNew = true;
            

            var customer = dataContext.Customers.Last();
            gridControl1.DataSource = customer;

           

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            clear();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }




       

        private void ribbon_Click(object sender, EventArgs e)
        {

        }


        private void InsertOrUpdate()
        {
            if (!dxValidationProvider1.Validate())
            {
                return;
            }
            if (IsExist)
            {
                var z = dataContext.Customers.Where(member => member.CustomerId == code).FirstOrDefault();

                z.CustomerName = Convert.ToString(CustomerName);
                z.CustomerPhone1 = CustomerPhone1.Text;
                z.CustomerPhone2 = CustomerPhone2.Text ;
                z.CustomerAddress = CustomerAddress.Text;
                z.CustomerEmail = CustomerEmail.Text ;
                z.CustomerNotes = CustomerNotes.Text ;
                z.CustomerFlag = Convert.ToInt32(CustomerFlag);
                z.FirstPerioudBalance = Convert.ToDecimal(FirstPerioudBalance);
                z.CustomerIsActive = Convert.ToBoolean(CustomerIsActive);

                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                clear();

            }
            else if (IsNew)
            {
                try
                {

                    test1.Database.Customer Cus = new Database.Customer()
                    {
                        CustomerName = CustomerName.Text,
                        CustomerPhone1 = CustomerPhone1.Text,
                        CustomerPhone2 = CustomerPhone2.Text,
                        CustomerAddress = CustomerAddress.Text,
                        CustomerEmail = CustomerEmail.Text,
                        CustomerNotes = CustomerNotes.Text,
                        CustomerFlag = Convert.ToInt32(CustomerFlag),
                        FirstPerioudBalance = Convert.ToDecimal(FirstPerioudBalance),
                        CustomerIsActive = Convert.ToBoolean(CustomerIsActive)
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