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
    public partial class DoctorForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }

        public DoctorForm()
        {
            InitializeComponent();
        }



        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }





        private void clear()
        {
            DoctorName.Text = "";
            DoctorAddress.Text = "";
            DoctorPhone.Text = "";
            DoctorAddress.Text = "";
            AppointmentFrom.Text = "";
            AppointmentTo.Text = "";
            IsActive.Checked = true;

            code = 0;
            IsNew = true;
            IsExist = false;

            var Doctor = dataContext.Doctors.ToList();
            gridControl1.DataSource = Doctor;
           
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
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
                var z = dataContext.Doctors.Where(member => member.DoctorId == code).FirstOrDefault();
                z.DoctorName = DoctorName.Text;
                z.DoctorAddress = DoctorAddress.Text;
                z.DoctorPhone = DoctorPhone.Text;
                z.AppointmentFrom = AppointmentFrom.Text;
                z.AppointmentTo = AppointmentTo.Text;
                z.IsActive = Convert.ToBoolean(IsActive);



                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                clear();

            }
            else if (IsNew)
            {
                try
                {
                    Doctor doctor = new Doctor()
                    {
                        DoctorName = DoctorName.Text,
                        DoctorAddress = DoctorAddress.Text,
                        DoctorPhone = DoctorPhone.Text,
                        AppointmentFrom = AppointmentFrom.Text,
                        AppointmentTo = AppointmentTo.Text,
                        IsActive = Convert.ToBoolean(IsActive),
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

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            code = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DoctorId"));
            var z = dataContext.Doctors.Where(member => member.DoctorId == code).FirstOrDefault();

            DoctorName.Text = z.DoctorName;
            DoctorAddress.Text = z.DoctorAddress;
            DoctorPhone.Text = z.DoctorPhone;
            AppointmentFrom.Text = z.AppointmentFrom;
            AppointmentTo.Text = z.AppointmentTo;
            IsActive.Checked = Convert.ToBoolean(z.IsActive);


            IsExist = true;
            IsNew = false;
        }
    }
    
}