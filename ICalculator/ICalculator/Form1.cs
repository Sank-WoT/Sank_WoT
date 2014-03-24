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
            Substractor substractor = new Substractor(); 
            resultField.Text = substractor.Calculate(firstArgument, secondArgument);
        }
    private void addition_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(firstField.Text);
            double secondArgument = Convert.ToDouble(secondField.Text);
             Additor additor = new Additor();
            resultField.Text = additor.Calculate(firstArgument, secondArgument);
        }

    private void multiplication_Click(object sender, EventArgs e)
    {
        double firstArgument = Convert.ToDouble(firstField.Text);
        double secondArgument = Convert.ToDouble(secondField.Text);
        Multiplication  multiplication = new Multiplication();
        resultField.Text = multiplication.Calculate(firstArgument, secondArgument);
    }

    private void division_Click(object sender, EventArgs e)
    {
        double firstArgument = Convert.ToDouble(firstField.Text);
        double secondArgument = Convert.ToDouble(secondField.Text);
        Division division = new Division();
        resultField.Text = division.Calculate(firstArgument, secondArgument);
    }
    private void involution_Click_1(object sender, EventArgs e)
    {
        double firstArgument = Convert.ToDouble(firstField.Text);
        double secondArgument = Convert.ToDouble(secondField.Text);
        Involution involution = new Involution();
        resultField.Text = involution.Calculate(firstArgument, secondArgument);
    }

    }
}
