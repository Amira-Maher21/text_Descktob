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
using test1.Classes;

namespace test1.Form
{
    public partial class employeeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OptDataContext dataContext = new OptDataContext();
        MainClass mainClass = new MainClass();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }

        public employeeForm()
        {
            InitializeComponent();
        }

        private void clear()
        {
            EmployeeName.Text = "";
            JobId.EditValue = null;
            UserNameLog.Text = "";
            EmployeeSalary.EditValue = null;
            EmployeePhone.Text = "";
            EmployeeAddress.Text = "";
            EmployeeIsActive.Checked = true;
            code = 0;
            IsExist = false;
            IsNew = true;

            gridControl1.DataSource = mainClass.SelectAllEmployeeData();

            JobId.Properties.DataSource = dataContext.Jobs.ToList();

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
                var z = dataContext.Employees.Where(member => member.EmployeeId == code).FirstOrDefault();
                z.EmployeeName = EmployeeName.Text;
                z.JobId = Convert.ToInt32(JobId.EditValue);
                z.UserNameLog = UserNameLog.Text;
                z.EmployeeSalary = Convert.ToDecimal(EmployeeSalary.EditValue);
                z.EmployeePhone = EmployeePhone.Text;
                z.EmployeeIsActive = Convert.ToBoolean(EmployeeIsActive.Checked);
                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                clear();

            }
            else if (IsNew)
            {
                try
                {
                    Employee employee = new Employee()
                    {
                    EmployeeName = EmployeeName.Text,
                    JobId = Convert.ToInt32(JobId.EditValue),
                    UserNameLog = UserNameLog.Text,
                    EmployeeSalary = Convert.ToDecimal(EmployeeSalary.EditValue),
                    EmployeePhone = EmployeePhone.Text,
                    EmployeeIsActive = Convert.ToBoolean(EmployeeIsActive.Checked),
                };
                    dataContext.SubmitChanges();
                    MessageBox.Show("تم الحفظ");
                    clear();
             }
                catch
                {
                    MessageBox.Show("من فضلك البيانات المطلوبة","خطا");
                }
            }

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            InsertOrUpdate();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            code = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "EmployeeId"));
            var z = dataContext.Employees.Where(member => member.EmployeeId == code).FirstOrDefault();

            EmployeeName.Text = z.EmployeeName;
            JobId.EditValue = z.JobId;
            UserNameLog.Text = z.UserNameLog;
            EmployeeSalary.EditValue = z.EmployeeSalary;
            EmployeePhone.Text = z.EmployeePhone;
            EmployeeIsActive.Checked = Convert.ToBoolean(z.EmployeeIsActive);
            IsExist = true;
            IsNew = false;
            
        }

        private void EditEmployeeSelect(int Id)

        {
            code = Id;
            var z = dataContext.Employees.Where(member => member.EmployeeId == code).FirstOrDefault();

            EmployeeName.Text = z.EmployeeName;
            JobId.EditValue = z.JobId;
            UserNameLog.Text = z.UserNameLog;
            EmployeeSalary.EditValue = z.EmployeeSalary;
            EmployeePhone.Text = z.EmployeePhone;
            EmployeeIsActive.Checked = Convert.ToBoolean(z.EmployeeIsActive);
            IsExist = true;
            IsNew = false;
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = mainClass.SelectAllEmployeeData();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}