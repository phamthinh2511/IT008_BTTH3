using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonlist = new Button[] {
                button1, button2, button3, button4, button5,
                button10, button9, button8, button7, button6,
                button15, button14, button13, button12, button11
            };
        }
        Button[] buttonlist;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button1.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 5000;
                textBox1.Text = currvalue.ToString();
                button1.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 5000;
                textBox1.Text = currvalue.ToString();
                button1.BackColor = Color.Blue;
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button3.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 5000;
                textBox1.Text = currvalue.ToString();
                button3.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 5000;
                textBox1.Text = currvalue.ToString();
                button3.BackColor = Color.Blue;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button2.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 5000;
                textBox1.Text = currvalue.ToString();
                button2.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 5000;
                textBox1.Text = currvalue.ToString();
                button2.BackColor = Color.Blue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button4.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 5000;
                textBox1.Text = currvalue.ToString();
                button4.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 5000;
                textBox1.Text = currvalue.ToString();
                button4.BackColor = Color.Blue;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button5.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 5000;
                textBox1.Text = currvalue.ToString();
                button5.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 5000;
                textBox1.Text = currvalue.ToString();
                button5.BackColor = Color.Blue;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button10.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 6500;
                textBox1.Text = currvalue.ToString();
                button10.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 6500;
                textBox1.Text = currvalue.ToString();
                button10.BackColor = Color.Blue;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button9.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 6500;
                textBox1.Text = currvalue.ToString();
                button9.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 6500;
                textBox1.Text = currvalue.ToString();
                button9.BackColor = Color.Blue;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button8.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 6500;
                textBox1.Text = currvalue.ToString();
                button8.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 6500;
                textBox1.Text = currvalue.ToString();
                button8.BackColor = Color.Blue;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button7.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 6500;
                textBox1.Text = currvalue.ToString();
                button7.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 6500;
                textBox1.Text = currvalue.ToString();
                button7.BackColor = Color.Blue;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button6.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 6500;
                textBox1.Text = currvalue.ToString();
                button6.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 6500;
                textBox1.Text = currvalue.ToString();
                button6.BackColor = Color.Blue;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button15.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 8000;
                textBox1.Text = currvalue.ToString();
                button15.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 8000;
                textBox1.Text = currvalue.ToString();
                button15.BackColor = Color.Blue;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button14.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 8000;
                textBox1.Text = currvalue.ToString();
                button14.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 8000;
                textBox1.Text = currvalue.ToString();
                button14.BackColor = Color.Blue;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button13.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 8000;
                textBox1.Text = currvalue.ToString();
                button13.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 8000;
                textBox1.Text = currvalue.ToString();
                button13.BackColor = Color.Blue;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button12.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 8000;
                textBox1.Text = currvalue.ToString();
                button12.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 8000;
                textBox1.Text = currvalue.ToString();
                button12.BackColor = Color.Blue;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đa được mua, vui lòng chọn ghế khác!");
                return;
            }
            if (button11.BackColor == Color.Blue)
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue -= 8000;
                textBox1.Text = currvalue.ToString();
                button11.BackColor = Color.White;
            }
            else
            {
                decimal currvalue = decimal.Parse(textBox1.Text);
                currvalue += 8000;
                textBox1.Text = currvalue.ToString();
                button11.BackColor = Color.Blue;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (var tmp in buttonlist)
            {
                if (tmp.BackColor == Color.Blue)
                {
                    tmp.BackColor = Color.Yellow;
                }
            }
            MessageBox.Show($"Số tiền cần thanh toán: {textBox1.Text}");
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            foreach (var tmp in buttonlist)
            {
                if (tmp.BackColor == Color.Blue)
                {
                    tmp.BackColor = Color.White;
                }
            }
            textBox1.Text = "0";
        }
    }
}
