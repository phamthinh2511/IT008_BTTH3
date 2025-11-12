using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Random randomGenerator = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = randomGenerator.Next(0, this.ClientSize.Width - 100);
            int y = randomGenerator.Next(0, this.ClientSize.Height - 30);

            // 2. Định nghĩa Font và Brush (màu sắc) cho chuỗi
            using (Font drawFont = new Font("Arial", 16, FontStyle.Bold))
            using (SolidBrush drawBrush = new SolidBrush(Color.Blue))
            {
                g.DrawString("Paint Event", drawFont, drawBrush, x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
