namespace Calculator
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;

        private static double Fibonacci(int n)
        {
            if (n < 0) throw new ArgumentException("Input must be non-negative.");
            if (n == 0) return 0;
            if (n == 1) return 1;

            double a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                double temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
        private void Evaluate()
        {
            if (operationPending)
            {
                if (string.IsNullOrEmpty(currentInput))
                {
                    textBox1.Text = "Enter a number";
                    return;
                }

                if (!double.TryParse(currentInput, out double secondNumber))
                {
                    textBox1.Text = "Invalid input";
                    return;
                }

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            textBox1.Text = "Can't divide by 0";
                            currentInput = "";
                            operationPending = false;
                            return;
                        }
                        break;
                    case "pow":
                        result = Math.Pow(result, secondNumber);
                        break;

                    case "fib":
                        if (secondNumber < 0 || secondNumber != Math.Floor(secondNumber))
                        {
                            textBox1.Text = "Input must be a non-negative integer";
                            currentInput = "";
                            operationPending = false;
                            return;
                        }
                        result = Fibonacci((int)secondNumber);
                        break;

                    case "log":
                        if (secondNumber <= 0)
                        {
                            textBox1.Text = "Input must be > 0";
                            currentInput = "";
                            operationPending = false;
                            return;
                        }
                        result = Math.Log(secondNumber);
                        break;

                    case "sqrt":
                        if (secondNumber < 0)
                        {
                            textBox1.Text = "Input must be non-negative";
                            currentInput = "";
                            operationPending = false;
                            return;
                        }
                        result = Math.Sqrt(secondNumber);
                        break;

                    case "abs":
                        result = Math.Abs(secondNumber);
                        break;

                    case "rec":
                        if (secondNumber == 0)
                        {
                            textBox1.Text = "Cannot divide by zero";
                            currentInput = "";
                            operationPending = false;
                            return;
                        }
                        result = 1 / secondNumber;
                        break;

                    default:
                        textBox1.Text = "No such operation";
                        return;
                }
                textBox1.Text = result.ToString();
                currentInput = "";
                operationPending = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void buttonPlus_Click(object sender, EventArgs e) => SetOperation("+");

        private void buttonMinus_Click(object sender, EventArgs e) => SetOperation("-");

        private void buttonDiv_Click(object sender, EventArgs e) => SetOperation("/");

        private void buttonMultiplication_Click(object sender, EventArgs e) => SetOperation("*");

        //Equals buton
        private void button12_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                if (string.IsNullOrEmpty(currentInput))
                    currentInput = "0";
                currentInput += ".";
                textBox1.Text = currentInput;
            }
        }
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                textBox1.Text = currentInput;
            }
        }
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (currentInput.StartsWith("-"))
                    currentInput = currentInput.Substring(1);
                else
                    currentInput = "-" + currentInput;
                textBox1.Text = currentInput;
            }
        }
        private void SetOperation(string op)
        {
            if (string.IsNullOrEmpty(currentInput))
                return;

            if (!double.TryParse(currentInput, out result))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentInput = "";
                return;
            }

            if (operationPending)
                Evaluate();

            operation = op;
            currentInput = "";
            operationPending = true;
        }

        private void buttonFloat_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                if (string.IsNullOrEmpty(currentInput))
                    currentInput = "0";
                currentInput += ".";
                textBox1.Text = currentInput;
            }
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += Math.PI;
            textBox1.Text = currentInput;
        }

        private void buttonFib_Click(object sender, EventArgs e) => SetOperation("fib");

        private void buttonPower_Click(object sender, EventArgs e) => SetOperation("pow");

        private void buttonLog_Click(object sender, EventArgs e) => SetOperation("log");

        private void buttonRootTwo_Click(object sender, EventArgs e) => SetOperation("sqrt");

        private void buttonAbsolute_Click(object sender, EventArgs e) => SetOperation("abs");

        private void buttonReciprocal_Click(object sender, EventArgs e) => SetOperation("rec");

    }
}
