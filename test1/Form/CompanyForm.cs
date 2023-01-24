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
    public partial class CompanyForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void clear()
        {
            CompaneDesc.Text = "";
            CompanyTaxFileNumber.Text = "";
            CompanyCommerceFileNumber.Text = "";
            CompanyPhone.Text = "";
            CompanyFax.Text = "";
            CompanyAddress.Text = "";
            CompanyLogo.Text = "";
            CompanyIsActive.Checked = true;

            code = 0;
            IsExist = false;
            IsNew = true;
            var company = dataContext.Companies.ToList();
            gridControl1.DataSource = company;

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            clear();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
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
                var c = dataContext.Companies.Where(member => member.CompanyId == code).FirstOrDefault();
                c.CompaneDesc = CompaneDesc.Text;
                c.CompanyTaxFileNumber = CompanyTaxFileNumber.Text;
                c.CompanyPhone = CompanyPhone.Text;
                c.CompanyFax = CompanyFax.Text;
                c.CompanyAddress = CompanyAddress.Text;
                c.CompanyLogo = CompanyLogo.Text;
                c.CompanyIsActive = Convert.ToBoolean(CompanyIsActive);


                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                clear();

            }
            else if (IsNew)
            {
                try
                {
                    Company company = new Company()
                    {
                        CompaneDesc = CompaneDesc.Text,
                        CompanyTaxFileNumber = CompanyTaxFileNumber.Text,
                        CompanyPhone = CompanyPhone.Text,
                        CompanyFax = CompanyFax.Text,
                        CompanyAddress = CompanyAddress.Text,
                        CompanyLogo = CompanyLogo.Text,
                        CompanyIsActive = Convert.ToBoolean(CompanyIsActive),

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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            code = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "company"));
            var c = dataContext.Companies.Where(member => member.CompanyId == code).FirstOrDefault();

            CompaneDesc.Text = c.CompaneDesc;
            CompanyTaxFileNumber.Text = c.CompanyTaxFileNumber;
            CompanyPhone.Text = c.CompanyPhone;
            CompanyFax.Text = c.CompanyFax;
            CompanyAddress.Text = c.CompanyAddress;
            CompanyLogo.Text = c.CompanyLogo;
            CompanyIsActive.Checked = Convert.ToBoolean(CompanyIsActive);


            IsExist = true;
            IsNew = false;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            InsertOrUpdate();
            
        }

        private void CompaneDesc_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}