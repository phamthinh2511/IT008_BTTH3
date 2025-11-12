using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void LogEvent(string eventName)
        {
            string logEntry = $"[{listBoxEvents.Items.Count + 1:D2}] - {eventName}";
            listBoxEvents.Items.Add(logEntry);
            listBoxEvents.TopIndex = listBoxEvents.Items.Count - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogEvent("2. Load (Form đang tải tài nguyên...)");
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            LogEvent("3. Activated (Form đã nhận focus)");
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            LogEvent("4. Shown (Form đã hiển thị xong)");
        }
        private void Form1_Deactivated(object sender, EventArgs e)
        {
            LogEvent("5. Deactivated (Form mất focus)");
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            LogEvent("Resize (Form thay đổi kích thước)");
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            LogEvent("Click (Click chuột vào Form)");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent("6. FormClosing (Form chuẩn bị đóng...)");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Đóng Form Thành Công.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
