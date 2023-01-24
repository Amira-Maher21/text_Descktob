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
    public partial class GroupForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }
        public GroupForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
           GroupDesc.Text = "";
           GroupIsActive.Checked = true;

            code = 0;
            IsExist = false;
            IsNew = true;

            var Group = dataContext.Groups.ToList();
            gridControl1.DataSource = Group;


        }

        
        private void GroupForm_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
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
                var g = dataContext.Groups.Where(member => member.GroupId == code).FirstOrDefault();
                g.GroupDesc=GroupDesc.Text;
                g.GroupIsActive = Convert.ToBoolean(GroupIsActive); 

                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                Clear();

            }
            else if (IsNew)
            {
                try
                {
                    Group group = new Group

                    {
                        GroupDesc = GroupDesc.Text,
                        GroupIsActive = Convert.ToBoolean(GroupIsActive.Checked),
                    };
                    dataContext.SubmitChanges();
                    MessageBox.Show("تم الحفظ");
                    Clear();
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
            code = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Group"));
            var g = dataContext.Groups.Where(member => member.GroupId == code).FirstOrDefault();

            GroupDesc.Text = g.GroupDesc;
           GroupIsActive.Checked = Convert.ToBoolean(GroupIsActive);


            IsExist = true;
            IsNew = false;
        }
    }
}