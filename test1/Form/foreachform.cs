using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace test1.Form
{
    public partial class foreachform : DevExpress.XtraEditors.XtraForm
    {
        public foreachform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = { "احمد", "محمد", "علي", "عزيز" };
            List<string> name = new List<string>();
            name.Add("ali");
            foreach (string n in names)
            {
                comboBox1.Items.Add(n);
                
            }

                    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] num = { 10,20,30 };

            //List<int> num = new List<int>();
            //num.Add (10);

            foreach (int m in num)
            {
                comboBox2.Items.Add(m);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num;
            string ms;
            num = Convert.ToInt32(comboBox1.SelectedIndex);
            ms = Convert.ToString(comboBox1.SelectedItem);

            textEdit1.EditValue = Convert.ToInt32(num);
            textEdit2.Text = ms;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num2;
            string num3;
            num2 = Convert.ToInt32(comboBox2.SelectedIndex);
            num3 = Convert.ToString(comboBox2.SelectedItem);

            textEdit3.EditValue = Convert.ToInt32(num2);
            textEdit4.Text = num3;
        }

        private void foreachform_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControlCollection collection = new ControlCollection(foreachform.ActiveForm);
            Control.ControlCollection control = new Control.ControlCollection(Owner);
            this.ActiveControl.BackColor = Color.Red;


            foreach (var crt in collection)
            {

            }
        }
    }
}