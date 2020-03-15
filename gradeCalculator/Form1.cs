using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double getGpa(double x)
        {
            if (x >= 96.5)
            {
                return 4.33;
            }

            else if (x >= 92.5)
            {
                return 4.00; 
            }

            else if(x >= 89.5)
            {
                return 3.67; 
            }

            else if (x >= 86.5)
            {
                return 3.33;
            }

            else if (x >= 82.5)
            {
                return 3.00; 
            }

            else if (x >= 79.5)
            {
                return 2.67;
            }

            else if (x >= 76.5)
            {
                return 2.33;
            }

            else if (x >= 72.5)
            {
                return 2.00;
            }

            else if (x >= 69.5)
            {
                return 1.67;
            }

            else if (x >= 66.5)
            {
                return 1.33; 
            }

            else  if (x >= 62.5)
            {
                return 1.00; 
            }

            else if (x >= 59.5)
            {
                return 0.67;
            }

            else
            {
                return 0.00;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double period1 = Convert.ToDouble(textBox1.Text);
            double period2 = Convert.ToDouble(textBox2.Text);
            double period3 = Convert.ToDouble(textBox3.Text);
            double period4 = Convert.ToDouble(textBox4.Text);
            double period5 = Convert.ToDouble(textBox5.Text);
            double period6 = Convert.ToDouble(textBox6.Text);

            double calculation = (getGpa(period1) + getGpa(period2) + getGpa(period3) + getGpa(period4) + getGpa(period5) +
                getGpa(period6)) / 6;

            lbl7.Text = calculation.ToString();


        }

       
    }
}
