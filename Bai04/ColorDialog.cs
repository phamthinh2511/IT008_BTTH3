using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai04
{
    public partial class ColorDialog : Form
    {
        public ColorDialog()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                string CurrColor = listBox1.Items[listBox1.SelectedIndex].ToString();
                Color color = Color.FromName(CurrColor);
                this.BackColor = color;
            }
        }

        private void ColorDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
