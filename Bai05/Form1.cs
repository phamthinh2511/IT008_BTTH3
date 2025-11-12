using System;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            if(int.TryParse(textBox1.Text, out n1))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số tại Number 1");
                return;
            }
            if (int.TryParse(textBox2.Text, out n2))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số tại Number 2");
                return;
            }

            int sum = n1 + n2;
            textBox3.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            if (int.TryParse(textBox1.Text, out n1))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số tại Number 1");
                return;
            }
            if (int.TryParse(textBox2.Text, out n2))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số tại Number 2");
                return;
            }

            int sub = n1 - n2;
            textBox3.Text = sub.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            if (int.TryParse(textBox1.Text, out n1))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số tại Number 1");
                return;
            }
            if (int.TryParse(textBox2.Text, out n2))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số tại Number 2");
                return;
            }

            int sum = n1 * n2;
            textBox3.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float n1;
            float n2;
            if (float.TryParse(textBox1.Text, out n1))
            {
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số tại Number 1");
                return;
            }
            if (float.TryParse(textBox2.Text, out n2))
            {
                if (float.Parse(textBox2.Text) == 0)
                {
                    MessageBox.Show("Không thể chia cho 0.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số tại Number 2");
                return;
            }

            float sum = n1 / n2;
            textBox3.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
