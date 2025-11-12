using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.UseWaitCursor = false;
            listView1.Cursor = Cursors.Default;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ChuyenNganhDuocChon = comboBox1.SelectedItem.ToString();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            switch (ChuyenNganhDuocChon)
            {
                case ("Khoa Học Máy Tính"):
                    LoadKHMT();
                    break;
                case ("Kỷ Thuật Máy Tính"):
                    LoadKTMT();
                    break;
                case ("Công Nghệ Thông Tin"):
                    LoadCNTT();
                    break;
                case ("Hệ Thống Thông Tin"):
                    LoadHTTT();
                    break;
                case ("Công Nghệ Phần Mềm"):
                    LoadCNPM();
                    break;
                case ("Trí Tuệ Nhân Tạo"):
                    LoadTTNT();
                    break;
                case ("An Toàn Thông Tin"):
                    LoadATTT();
                    break;
            }
        }
        private void LoadKHMT()
        {
            listBox1.Items.Add("N");
            listBox1.Items.Add("Gà");
            listBox1.Items.Add("Đ");
        }
        private void LoadKTMT()
        {
            listBox1.Items.Add("N");
            listBox1.Items.Add("Gà");
            listBox1.Items.Add("Đ");
        }
        private void LoadCNTT()
        {
            listBox1.Items.Add("N");
            listBox1.Items.Add("Gà");
            listBox1.Items.Add("Đ");
        }
        private void LoadATTT()
        {
            listBox1.Items.Add("N");
            listBox1.Items.Add("Gà");
            listBox1.Items.Add("Đ");
        }
        private void LoadHTTT()
        {
            listBox1.Items.Add("N");
            listBox1.Items.Add("Gà");
            listBox1.Items.Add("Đ");
        }
        private void LoadCNPM()
        {
            listBox1.Items.Add("N");
            listBox1.Items.Add("Gà");
            listBox1.Items.Add("Đ");
        }
        private void LoadTTNT()
        {
            listBox1.Items.Add("Ni");
            listBox1.Items.Add("Gà");
            listBox1.Items.Add("Đ");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem.ToString());
                listBox2.Items.Remove(listBox2.SelectedItem.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                comboBox1.SelectedIndex < 0 ||
                listBox2.Items.Count == 0 ||
                (!checkBox1.Checked && !checkBox2.Checked))
            {
                MessageBox.Show("Thông tin thiếu, vui lòng nhập đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem existingItem = SearchItemByMSSV(textBox1.Text);
            if (existingItem != null)
            {
                existingItem.SubItems[2].Text = textBox2.Text;
                existingItem.SubItems[3].Text = comboBox1.Text;
                existingItem.SubItems[4].Text = listBox2.Items.Count.ToString();
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                int stt = listView1.Items.Count + 1;
                ListViewItem newItem = new ListViewItem(stt.ToString());
                newItem.SubItems.Add(textBox1.Text);
                newItem.SubItems.Add(textBox2.Text);
                newItem.SubItems.Add(comboBox1.Text);
                newItem.SubItems.Add(listBox2.Items.Count.ToString());
                newItem.SubItems.Add(checkBox1.Checked ? "Nam" : "Nữ");
                listView1.Items.Add(newItem);
            }
            INPUTCLEAR();
            listView1.UseWaitCursor = false;
            listView1.Cursor = Cursors.Default;
            Application.UseWaitCursor = false;
        }

        private ListViewItem SearchItemByMSSV(string text)
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

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thông tin sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    UPDSTT();
                    INPUTCLEAR();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng một tài khoản để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var sel = listView1.SelectedItems[0];
                textBox1.Text = sel.SubItems[1].Text;
                textBox2.Text = sel.SubItems[2].Text;
                comboBox1.Text = sel.SubItems[3].Text;
                comboBox1_SelectedIndexChanged(sender, e);
                if (sel.SubItems[5].Text == "Nam")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox2.Checked = true;
                }
            }
        }
        private void INPUTCLEAR()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.ResetText();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.ReadOnly = false;
            textBox1.BackColor = Color.White;

            listView1.SelectedItems.Clear();
            textBox1.Focus();
        }
        private void UPDSTT()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

