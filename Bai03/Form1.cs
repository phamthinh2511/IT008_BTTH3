using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private Random RandomColorGen;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomColorGen = new System.Random();
            int red = RandomColorGen.Next(0, 256);
            int blue = RandomColorGen.Next(0, 256);
            int green = RandomColorGen.Next(0, 256);

            Color randomColor = Color.FromArgb(red, green, blue);
            this.BackColor = randomColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
