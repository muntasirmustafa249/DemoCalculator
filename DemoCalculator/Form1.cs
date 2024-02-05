namespace DemoCalculator
{
    public partial class Form1 : Form
    {
        private int number1 = 0;
        private int number2 = 0;
        private string input = "0";
        private string mathOperator = "";

        private enum InputState
        {
            Num1Init,
            Num1Entry,
            Num2Init,
            Num2Entry,
            Result
        }

        private InputState state;
        public Form1()
        {
            InitializeComponent();
            UpdateCalculatorState(InputState.Num1Init);
        }

        private void UpdateCalculatorState(InputState updatdState)
        {
            state = updatdState;
            UpdateCalculatorInputAvailability(state);
            UpdateCalculatorLabelCaption(state);
            UpdateCalculatorNumberAndNumberCaption(state);
        }

        private void UpdateCalculatorNumberAndNumberCaption(InputState state)
        {
            switch (state)
            {
                case InputState.Num1Init:
                    mathOperator = "";
                    number1 = 0;
                    number2 = 0;
                    labelOperator.Text = "";
                    labelNumber1.Text = number1.ToString();
                    labelNumber2.Text = number2.ToString();
                    break;
                case InputState.Num1Entry:
                    break;
                case InputState.Num2Init:
                    if (labelInputAndResult.Text.All((digit) => char.IsDigit(digit)))
                    {
                        number1 = Convert.ToInt32(labelInputAndResult.Text);
                        labelNumber1.Text = number1.ToString();
                    }
                    break;
                case InputState.Num2Entry:
                    break;
                case InputState.Result:
                    if (labelInputAndResult.Text.All((digit) => char.IsDigit(digit)))
                    {
                        number2 = Convert.ToInt32(labelInputAndResult.Text);
                        labelNumber2.Text = number2.ToString();
                    }
                    break;
                    //default:
                    //break;
            }
        }

        private void UpdateCalculatorLabelCaption(InputState state)
        {
            switch (state)
            {
                case InputState.Num1Init:
                //break;
                case InputState.Num1Entry:
                //break;
                case InputState.Num2Init:
                //break;
                case InputState.Num2Entry:
                    if (labelInputAndResultCaption.Text != "Input") labelInputAndResultCaption.Text = "Input";
                    break;
                case InputState.Result:
                    labelInputAndResultCaption.Text = "Result";
                    break;
                    //default:
                    //break;
            }
        }

        private void UpdateCalculatorInputAvailability(InputState state)
        {
            switch (state)
            {
                case InputState.Num1Init:
                    //Disable0();
                    EnableNumbers();
                    DisableOperators();
                    DisableResult();
                    break;
                case InputState.Num1Entry:
                    //Enable0();
                    EnableNumbers();
                    EnableOperators();
                    DisableResult();
                    break;
                case InputState.Num2Init:
                    //Disable0();
                    EnableNumbers();
                    DisableOperators();
                    DisableResult();
                    break;
                case InputState.Num2Entry:
                    //Enable0();
                    EnableNumbers();
                    DisableOperators();
                    EnableResult();
                    break;
                case InputState.Result:
                    DisableNumbers();
                    DisableOperators();
                    DisableResult();
                    break;
                    //default:
                    //break;
            }
        }

        private void DisableOperators()
        {
            buttonAdd.Enabled = false;
            buttonSubtract.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivide.Enabled = false;
        }

        private void EnableOperators()
        {
            buttonAdd.Enabled = true;
            buttonSubtract.Enabled = true;
            buttonMultiply.Enabled = true;
            buttonDivide.Enabled = true;
        }

        private void DisableNumbers()
        {
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void EnableNumbers()
        {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        /*private void Disable0()
        {
            button0.Enabled = false;
        }

        private void Enable0()
        {
            button0.Enabled = true;
        }*/

        private void DisableResult()
        {
            buttonResult.Enabled = false;
        }

        private void EnableResult()
        {
            buttonResult.Enabled = true;
        }

        private void SetOperator(string mathOperator)
        {
            this.mathOperator = mathOperator;
            labelOperator.Text = mathOperator;
        }

        private void ResetInput()
        {
            input = "0";
            labelInputAndResult.Text = input;
        }

        private void UpdateCalculatorStateDuringDigitEntry()
        {
            if (input == "0" && (state == InputState.Num1Init || state == InputState.Num2Init)) return;
            if (state == InputState.Num1Init) UpdateCalculatorState(InputState.Num1Entry);
            else if (state == InputState.Num2Init) UpdateCalculatorState(InputState.Num2Entry);
        }

        private void AddDigitToInput(string digit)
        {
            if (input == "0") input = digit;
            else input += digit;
            labelInputAndResult.Text = input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button0.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button1.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button2.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button3.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button4.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button5.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button6.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button7.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button8.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDigitToInput(button9.Text);
            UpdateCalculatorStateDuringDigitEntry();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SetOperator(buttonAdd.Text);
            UpdateCalculatorState(InputState.Num2Init);
            ResetInput();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            SetOperator(buttonSubtract.Text);
            UpdateCalculatorState(InputState.Num2Init);
            ResetInput();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            SetOperator(buttonMultiply.Text);
            UpdateCalculatorState(InputState.Num2Init);
            ResetInput();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            SetOperator(buttonDivide.Text);
            UpdateCalculatorState(InputState.Num2Init);
            ResetInput();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            UpdateCalculatorState(InputState.Num1Init);
            ResetInput();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            UpdateCalculatorState(InputState.Result);

            if (mathOperator == "/" && number2 == 0)
            {
                MessageBox.Show("Can't divide Number 1 by 0.");
                UpdateCalculatorState(InputState.Num2Entry);
                return;
            }

            labelInputAndResult.Text = ReturnCalculationResult(number1, number2, mathOperator);
        }

        private string ReturnCalculationResult(int number1, int number2, string mathOperator)
        {
            if (mathOperator == "+") return (number1 + number2).ToString();
            else if (mathOperator == "-") return (number1 - number2).ToString();
            else if (mathOperator == "*") return (number1 * number2).ToString();
            else if (mathOperator == "/")
            {
                var result = (double)number1 / number2;
                if (result == (int)result) return ((int)result).ToString();
                else return result.ToString("#.########").TrimEnd('0');
            }
            else
            {
                MessageBox.Show("Can't recognize math operator");
                return number2.ToString();
            }
        }
    }
}
