using System;
using System.Windows.Forms;
using ICalculator.BinaryCalculators;
using ICalculator.SortiOperation;
using ICalculator.UnaryCalculators;

namespace ICalculator
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

        private void Calculate(string name)
        {
            double firstArgument = Convert.ToDouble(firstField.Text);
            double secondArgument = Convert.ToDouble(secondField.Text);
            IBinaryCalculator calculator = BinaryCalculatorsFactory.CreateBinaryCalculator(name);
            resultField.Text = calculator.Calculate(firstArgument, secondArgument).ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Calculate1("sqrt");
        }

        private void Napierian_Click(object sender, EventArgs e)
        {
            Calculate1("e^x");
        }

        private void arcsin_Click(object sender, EventArgs e)
        {
            Calculate1("arcsin(x)");
        }

        private void arccos_Click(object sender, EventArgs e)
        {
            Calculate1("arccos(x)");
        }

        private void logx_Click(object sender, EventArgs e)
        {
            Calculate1("log2(x)");
        }

        private void arctg_Click(object sender, EventArgs e)
        {
            Calculate1("arctg(x)");
        }

        private void sin_Click(object sender, EventArgs e)
        {
            Calculate1("sin(x)");
        }

        private void cos_Click(object sender, EventArgs e)
        {
            Calculate1("cos(x)");
        }

        private void tan_Click(object sender, EventArgs e)
        {
            Calculate1("tan(x)");
        }

        private void cot_Click(object sender, EventArgs e)
        {
            Calculate1("cot(x)");
        }

        private void ln_Click(object sender, EventArgs e)
        {
            Calculate1("ln(x)");
        }

        private void Calculate1(string name)
        {
            double firstArgument = Convert.ToDouble(firstField.Text);
            IUnaryCalculator calculator = UnaryCalculatorsFactory.CreateBinaryCalculator(name);
            resultField.Text = calculator.Calculate(firstArgument).ToString();
        }

        private void Descending_Click(object sender, EventArgs e)
        {
            CalculateArray("<");
        }

        private void Ascending_Click(object sender, EventArgs e)
        {
            CalculateArray(">");
        }

        private void CalculateArray(string name)
        {

            string[] stringArgument = firstField.Text.Split(' ');
            int[] intArray = new int[stringArgument.Length];
            for (int i = 0; i < stringArgument.Length; i++)
            {
                intArray[i] = Convert.ToInt32(stringArgument[i]);
            }
            ISortiOperation calculator = SortiOperationFactoryc.CreateSortiOperation(name);
            int[] resultArray = calculator.Sort(intArray);
            string result = string.Empty;
            for (int j = 0; j < stringArgument.Length; j++)
            {
                result += resultArray[j] + " ";
            }
            resultField.Text = result;

        }


    }
}


