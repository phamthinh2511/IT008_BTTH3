using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Thông tin thiếu, vui lòng nhập đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem existingitem = SearchItemBySoTaiKhoan(textBox1.Text);
            if (existingitem != null)
            {
                existingitem.SubItems[2].Text = textBox2.Text;
                existingitem.SubItems[3].Text = textBox3.Text;
                existingitem.SubItems[4].Text = textBox4.Text;
                MessageBox.Show($"Cập nhật thông tin thành công cho khách hàng: {textBox1.Text}");
            }
            else
            {
                int stt = listView1.Items.Count + 1;
                ListViewItem newItem = new ListViewItem(stt.ToString());
                newItem.SubItems.Add(textBox1.Text);
                newItem.SubItems.Add(textBox2.Text);
                newItem.SubItems.Add(textBox3.Text);
                newItem.SubItems.Add(textBox4.Text);
                listView1.Items.Add(newItem);
            }
            UPDSTT();
            UPDTONGTIEN();
            INPUTCLEAR();
        }

        private void INPUTCLEAR()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.ReadOnly = false;
            textBox1.BackColor = Color.White;

            listView1.SelectedItems.Clear();
            textBox1.Focus();
        }

        private void UPDTONGTIEN()
        {
            decimal tongTien = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                tongTien += decimal.Parse(item.SubItems[4].Text);
            }
            textBox5.Text = tongTien.ToString();
        }

        private void UPDSTT()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thông tin khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);

                    UPDSTT();
                    UPDTONGTIEN();
                    INPUTCLEAR();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng một tài khoản để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private ListViewItem SearchItemBySoTaiKhoan(string text)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == text)
                {
                    return item;
                }
            }
            return null;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var sel = listView1.SelectedItems[0];
                textBox1.Text = sel.SubItems[1].Text;
                textBox2.Text = sel.SubItems[2].Text;
                textBox3.Text = sel.SubItems[3].Text;
                textBox4.Text = sel.SubItems[4].Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
