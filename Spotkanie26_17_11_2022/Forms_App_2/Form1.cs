using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_App_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);

                if (radioButton1.Checked)
                {
                    double w = x + y;
                    textBox3.Text = w.ToString();
                }
                else if (radioButton2.Checked)
                {
                    double w = x - y;
                    textBox3.Text = w.ToString();
                }
                else if (radioButton3.Checked)
                {
                    double w = x * y;
                    textBox3.Text = w.ToString();
                }
                else if (radioButton4.Checked)
                {
                    double w = x / y;
                    textBox3.Text = w.ToString();
                }
                else
                {
                    textBox3.Text = "Nic nie wybrano";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("operation prformed...");
            }


            

        }
    }
}
