using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        string operation;
        double operand1;
        bool isNewEntry;
        double memoryValue;
        public Form1()
        {
            InitializeComponent();
            operation = "";
            operand1 = 0;
            isNewEntry = true;
            memoryValue = 0;
            
        }
        private void numberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (isNewEntry)
            {
                txtDisplay.Text = "0";
                isNewEntry = false;
            }
            if (btn.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += ".";
                }
            }
            else
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = btn.Text;
                }
                else
                {
                    txtDisplay.Text += btn.Text;
                }
            }
        }
        private void operatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isNewEntry && operation != "")
            {
                equalsButton_Click(sender, e);
            }
            operand1 = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isNewEntry = true;
        }
        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                return;
            }

            double operand2 = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+": result = operand1 + operand2; break;
                case "-": result = operand1 - operand2; break;
                case "*": result = operand1 * operand2; break;
                case "/":
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = 0;
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;
            }

            txtDisplay.Text = result.ToString();
            operation = "";
            isNewEntry = true;
        }
        private void unaryOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double currentValue = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (btn.Text)
            {
                case "sqrt":
                    if (currentValue < 0)
                    {
                        MessageBox.Show("Invalid input for square root.", "Error");
                        return;
                    }
                    result = Math.Sqrt(currentValue);
                    break;
                case "1/x":
                    if (currentValue == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error");
                        return;
                    }
                    result = 1 / currentValue;
                    break;
                case "+/-":
                    result = -currentValue;
                    break;
                case "%":
                    result = operand1 * (currentValue / 100);
                    break;
            }

            txtDisplay.Text = result.ToString();
            isNewEntry = true;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            operand1 = 0;
            operation = "";
            isNewEntry = true;
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            isNewEntry = true;
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (isNewEntry) return;

            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                isNewEntry = true;
            }
        }
        private void memoryButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double currentValue = double.Parse(txtDisplay.Text);

            switch (btn.Text)
            {
                case "MS":
                    memoryValue = currentValue;
                    lblMemoryIndicator.Text = memoryValue.ToString();
                    isNewEntry = true;
                    break;
                case "MR":
                    txtDisplay.Text = memoryValue.ToString();
                    isNewEntry = true;
                    break;
                case "MC":
                    memoryValue = 0;
                    lblMemoryIndicator.Text = ""; 
                    break;
                case "M+": 
                    memoryValue += currentValue;
                    isNewEntry = true;
                    break;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
