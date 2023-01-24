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
    public partial class SignalTypeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }


        public SignalTypeForm()
        {
            InitializeComponent();
        }







        private void clear()
        {
            SignalTypeDesc.Text = "";

            code = 0;
            IsExist = false;
            IsNew = true;

            var signaltype  = dataContext.SignalTypes.ToList();
            gridControl1.DataSource = signaltype;

        }

        private void SignalTypeForm_Load(object sender, EventArgs e)
        {

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
                var s = dataContext.SignalTypes.Where(member => member.SignalTypeId == code).FirstOrDefault();

                s.SignalTypeDesc = SignalTypeDesc.Text;

                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                clear();

            }
            else if (IsNew)
            {
                try
                {
                   SignalType signal = new SignalType()
                    {
                        SignalTypeDesc = SignalTypeDesc.Text,
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
            code = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SignalTypeId"));
            var s = dataContext.SignalTypes.Where(member => member.SignalTypeId == code).FirstOrDefault();

            SignalTypeDesc.Text = s.SignalTypeDesc;


            IsExist = true;
            IsNew = false;
        }
    }
}