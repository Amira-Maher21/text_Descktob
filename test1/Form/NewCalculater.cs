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
    public partial class NewCalculater : DevExpress.XtraEditors.XtraForm
    {
        public NewCalculater()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        string c;
        double x;

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + " " + c;
            textBox1.Clear();


        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x + y).ToString();
                        label1.Text = " ";

                    }
                    break;

                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x - y).ToString();
                        label1.Text = " ";

                    }
                    break;

                case "*":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x * y).ToString();
                        label1.Text = " ";

                    }
                    break;

                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x / y).ToString();
                        label1.Text = " ";

                    }
                    break;
                  

                    }
                 }




        private void button17_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")

            {
                textBox1.Clear();

            }

            if (textBox1.Text == "." && b.Text == ".")
                textBox1.Text = "0.";




            textBox1.Text = textBox1.Text + b.Text;
        }

     
        private void button18_Click(object sender, EventArgs e)
        {
            {
                Button b = (Button)sender;
                c = b.Text;
                x = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + " " + c;
                textBox1.Clear();


            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double val = double.Parse(textBox1.Text);
            val = Math.Pow(val, 2);
            textBox1.Text = val.ToString();



        }

        private void button19_Click(object sender, EventArgs e)
        {
            Double val = double.Parse(textBox1.Text);
            val = Math.Log10(val);
            textBox1.Text = val.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Double val = double.Parse(textBox1.Text);
            val = Math.Pow(val, 3);
            textBox1.Text = val.ToString();
        }

        private void button18_Click_2(object sender, EventArgs e)
        {
            Double val = double.Parse(textBox1.Text);
            val = val / 100;
            textBox1.Text = val.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCalculater_Load(object sender, EventArgs e)
        {

        }
    }
}