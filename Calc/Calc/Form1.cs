namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double currentNumber;
        private string currentOperator;
        private double currentResult;
        private bool isNewInput = true;


        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewInput)
            {
                txtDisplay.Clear();
                isNewInput = false;
            }

            txtDisplay.Text += button.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                currentNumber = double.Parse(txtDisplay.Text);
                currentOperator = ((Button)sender).Text;
                txtDisplay.Clear();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtDisplay.Text);

            switch (currentOperator)
            {
                case "+":
                    currentResult = currentNumber + secondNumber;
                    break;
                case "-":
                    currentResult = currentNumber - secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        currentResult = currentNumber / secondNumber;
                    }
                    else
                    {
                        txtDisplay.Text = "ERROR";
                    }
                    break;
                case "*":
                    currentResult = currentNumber * secondNumber;
                    break;
            }

            txtDisplay.Text = currentResult + "";
            isNewInput = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            currentNumber = 0;
            currentOperator = "";
            currentResult = 0;
            isNewInput = true;
        }

    }
}