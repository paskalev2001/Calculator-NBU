namespace Calculator
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;

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

            if (operationPending)
                Evaluate();

            operation = op;
            result = double.Parse(currentInput);
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
    }
}
