using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
        
    {
        MYcalculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator=new CalculatorV01();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber1_ValueChanged(object sender, EventArgs e)
        {
 
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (validateinputs())
            {
                int sum = calculator.plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum is: " + sum);
            }
        }

            bool validateinputs()
            {
                bool isvalid = true;
                if (txtNumber1.Value == 0)
                {
                    isvalid = false;
                    MessageBox.Show("لطفا عدد اول را وارد نمایید");
                }
                else
                {
                    if (txtNumber2.Value == 0)
                    {
                        isvalid = false;
                        MessageBox.Show("لطفا عدد دوم را وارد نمایید");
                    }
                }
                return isvalid;
            }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (validateinputs())
            {
                int minus = calculator.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Minus is: " + minus);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (validateinputs())
            {
                int multiple = calculator.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Multiple is: " + multiple);
            }

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (validateinputs())
            {
                int divide = calculator.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Division is: " + divide);
            }
        }
    }
}
