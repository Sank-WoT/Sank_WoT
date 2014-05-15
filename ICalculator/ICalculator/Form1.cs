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

        private void involution_Click(object sender, EventArgs e)
        {
            Calculate("^");
        }

        private void Calculate(string name)
        {
            try
            {
                double firstArgument = Convert.ToDouble(firstField.Text);
                double secondArgument = Convert.ToDouble(secondField.Text);
                IBinaryCalculator calculator = BinaryCalculatorsFactory.CreateBinaryCalculator(name);
                resultField.Text = calculator.Calculate(firstArgument, secondArgument).ToString();
            }
            catch (Exception e)
            {
                resultField.Text = e.Message;
            }

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            CalculateUnary("sqrt");
        }

        private void Napierian_Click(object sender, EventArgs e)
        {
            CalculateUnary("e^x");
        }

        private void arcsin_Click(object sender, EventArgs e)
        {
            CalculateUnary("arcsin(x)");
        }

        private void arccos_Click(object sender, EventArgs e)
        {
            CalculateUnary("arccos(x)");
        }

        private void logx_Click(object sender, EventArgs e)
        {
            CalculateUnary("log2(x)");
        }

        private void arctg_Click(object sender, EventArgs e)
        {
            CalculateUnary("arctg(x)");
        }

        private void sin_Click(object sender, EventArgs e)
        {
            CalculateUnary("sin(x)");
        }

        private void cos_Click(object sender, EventArgs e)
        {
            CalculateUnary("cos(x)");
        }

        private void tan_Click(object sender, EventArgs e)
        {
            CalculateUnary("tan(x)");
        }

        private void cot_Click(object sender, EventArgs e)
        {
            CalculateUnary("cot(x)");
        }

        private void ln_Click(object sender, EventArgs e)
        {
            CalculateUnary("ln(x)");
        }

        private void CalculateUnary(string name)
        {
            try
            {
                double firstArgument = Convert.ToDouble(firstField.Text);
                IUnaryCalculator calculator = UnaryCalculatorsFactory.CreateBinaryCalculator(name);
                resultField.Text = calculator.Calculate(firstArgument).ToString();
            }
            catch (Exception e)
            {
                resultField.Text = e.Message;
            }

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
            try
            {
                string[] stringArgument = firstField.Text.Split(' ');
                var intArray = new int[stringArgument.Length];
                for (int i = 0; i < stringArgument.Length; i++)
                {
                    intArray[i] = Convert.ToInt32(stringArgument[i]);
                }
                ISortiOperation calculator = SortingOperationFactory.CreateSortiOperation(name);
                int[] resultArray = calculator.Sort(intArray);
                string result = string.Empty;
                for (int j = 0; j < stringArgument.Length; j++)
                {
                    result += resultArray[j] + " ";
                }
                resultField.Text = result;
            }
            catch (Exception e)
            {
                resultField.Text = e.Message;
            }
        }
    }
}


