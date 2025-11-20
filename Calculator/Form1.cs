using System;
using System.Windows.Forms;
using Calculator.Core;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private readonly CalculatorEngine _engine = new CalculatorEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            _engine.AppendInput(button.Text);
            textBox1.Text = _engine.GetDisplayText();
        }

        private void button0_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button1_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button4_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button5_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button6_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button9_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);

        //  Decimal / float button
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            _engine.InsertDecimal();
            textBox1.Text = _engine.GetDisplayText();
        }

        private void buttonFloat_Click(object sender, EventArgs e)
        {
            _engine.InsertDecimal();
            textBox1.Text = _engine.GetDisplayText();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            _engine.Backspace();
            textBox1.Text = _engine.GetDisplayText();
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            _engine.ToggleSign();
            textBox1.Text = _engine.GetDisplayText();
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            _engine.SetPi();
            textBox1.Text = _engine.GetDisplayText();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _engine.Clear();
            textBox1.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                _engine.Evaluate();
                textBox1.Text = _engine.GetDisplayText();
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
                _engine.Clear();
            }
        }

        //  Helper for binary/unary operations
        private void HandleOperation(string symbol)
        {
            try
            {
                if (symbol == "-" && string.IsNullOrEmpty(_engine.CurrentInput) && !_engine.OperationPending)
                {
                    _engine.AppendInput("-");
                }
                else
                {
                    _engine.SetOperation(symbol);
                }

                textBox1.Text = _engine.GetDisplayText();
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
                _engine.Clear();
            }
        }

        // Calling button events
        private void buttonPlus_Click(object sender, EventArgs e) => HandleOperation("+");
        private void buttonMinus_Click(object sender, EventArgs e) => HandleOperation("-");
        private void buttonDiv_Click(object sender, EventArgs e) => HandleOperation("/");
        private void buttonMultiplication_Click(object sender, EventArgs e) => HandleOperation("*");

        private void buttonFib_Click(object sender, EventArgs e) => HandleOperation("fib");
        private void buttonPower_Click(object sender, EventArgs e) => HandleOperation("pow");
        private void buttonLog_Click(object sender, EventArgs e) => HandleOperation("log");
        private void buttonRootTwo_Click(object sender, EventArgs e) => HandleOperation("sqrt");
        private void buttonAbsolute_Click(object sender, EventArgs e) => HandleOperation("abs");
        private void buttonReciprocal_Click(object sender, EventArgs e) => HandleOperation("rec");

        
    }
}