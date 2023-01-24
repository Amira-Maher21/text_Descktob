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
    public partial class jobsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //أخذ اوبجيكت من الداتا بيز
        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }

        public jobsForm()
        {
            InitializeComponent();
        }

        private void jobsForm_Load(object sender, EventArgs e)
        {
            JobIsActive.Checked = true;

            var job = dataContext.Jobs.ToList();
            gridControl1.DataSource = job;
        }



        private void Clear()
        {
            JobDescr.Text = "";
            JobIsActive.Checked = true;
            code = 0;
            IsExist = false;
            IsNew = true;
            var job = dataContext.Jobs.ToList();
            gridControl1.DataSource = job;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            { return; }
            try
            {
                Job job = new Job();

                job.JobDesc = Convert.ToString(JobDescr.Text);
                job.JobISActive = Convert.ToBoolean(JobIsActive.Checked);

                dataContext.Jobs.InsertOnSubmit(job);
                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                Clear();
            }
            catch
            {

                MessageBox.Show("لم يتم الحفظ");
            }


        }
      
    }
}