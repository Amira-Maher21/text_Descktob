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
    public partial class Calculator : DevExpress.XtraEditors.XtraForm
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            
        }

        private void num1_Click(object sender, EventArgs e)
        {
          

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void num9_Click_1(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string a;
            int b;
            string c;
               SimpleButton x = (SimpleButton) sender;
            c = x.Text;
            a = textEdit2.Text;
            b = Convert.ToInt32(c);
            for (int i = 0; i < b; i++)
            {
                if (c=="1")
                {
                    MessageBox.Show(a);
                    textEdit2.ReadOnly = true;
                }
                else if (c=="4")
                {
                    MessageBox.Show(a);
                    textEdit2.ReadOnly = false;
                }
           

            }
        }
    }
}