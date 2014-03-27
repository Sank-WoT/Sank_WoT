using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICalculator;
using ICalculator.BinaryCalculators;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }
    private void addition_Click(object sender, EventArgs e)
        {
            Calculate("+");
        }

    private void multiplication_Click(object sender, EventArgs e)
    {
        Calculate("*");
    }

    private void division_Click(object sender, EventArgs e)
    {
        Calculate("/");
    }
    private void involution_Click_1(object sender, EventArgs e)
    {
       Calculate("^");
    }

    /*private void sqrt_Click(object sender, EventArgs e)
    {
        double firstArgument = Convert.ToDouble(firstField.Text);
        double secondArgument = Convert.ToDouble(secondField.Text);
        Sqrt sqrt = new Sqrt();
        resultField.Text = sqrt.Calculate(firstArgument, secondArgument);
    }*/
          private void Calculate(string name)
        {
            double firstArgument = Convert.ToDouble(firstField.Text);
            double secondArgument = Convert.ToDouble(secondField.Text);
            IBinaryCalculator calculator = BinaryCalculatorsFactory.CreateBinaryCalculator(name);
            resultField.Text = calculator.Calculate(firstArgument, secondArgument);
        }

          private void sqrt_Click(object sender, EventArgs e)
          {

          }

    }
}


