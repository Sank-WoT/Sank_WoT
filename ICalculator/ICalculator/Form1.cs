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
            double firstArgument = Convert.ToDouble(firstField.Text);
            double secondArgument = Convert.ToDouble(secondField.Text);
            double result = firstArgument - secondArgument;
            resultField.Text = result.ToString();
        }
    private void addition_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(firstField.Text);
            double secondArgument = Convert.ToDouble(secondField.Text);
            double result = firstArgument + secondArgument;
            resultField.Text = result.ToString();
        }

    private void multiplication_Click(object sender, EventArgs e)
    {
        double firstArgument = Convert.ToDouble(firstField.Text);
        double secondArgument = Convert.ToDouble(secondField.Text);
        double result = firstArgument * secondArgument;
        resultField.Text = result.ToString();
    }

    private void division_Click(object sender, EventArgs e)
    {
        double firstArgument = Convert.ToDouble(firstField.Text);
        double secondArgument = Convert.ToDouble(secondField.Text);
        double result = firstArgument / secondArgument;
        resultField.Text = result.ToString();
    }

    }
}
