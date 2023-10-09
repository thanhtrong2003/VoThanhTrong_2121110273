using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vothanhtrong2121110273_buoi1
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
            dgvEmployee.CellClick += dgvEmployee_CellClick;
        }

        private bool IsNumeric(string value)
        {
            return value.All(char.IsDigit);
        }
        private bool IsDuplicateID(string id)
        {
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }
        private void btAddNew_Click(object sender, EventArgs e)
        {

            if (!IsNumeric(tbId.Text))
            {
                MessageBox.Show("ID chỉ nên chứa số. Vui lòng nhập lại.");
                return;
            }

            if (IsDuplicateID(tbId.Text))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }
            // Get the image from PictureBox
            if (pbImage.Image != null)
            {
                dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked, pbImage.Image);
            }
            else
            {
                // Handle the case where the PictureBox doesn't have an image.
                MessageBox.Show("Please select a valid image first.");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;
            dgvEmployee.Rows.RemoveAt(idx);
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
            tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());

            pbImage.Image = (Image)dgvEmployee.Rows[idx].Cells["imageCol"].Value;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];

                selectedRow.Cells[0].Value = tbId.Text;
                selectedRow.Cells[1].Value = tbName.Text;
                selectedRow.Cells[2].Value = tbAge.Text;
                selectedRow.Cells[3].Value = ckGender.Checked;
                selectedRow.Cells["imageCol"].Value = pbImage.Image;

                // Optionally, if you want to refresh the DataGridView
                dgvEmployee.Refresh();
            }

        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg) |*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = dlg.FileName;
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng không nhấp vào tiêu đề cột
            {
                tbId.Text = dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                ckGender.Checked = bool.Parse(dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString());

                // Nếu bạn có một cột hình ảnh
                if (dgvEmployee.Rows[e.RowIndex].Cells["imageCol"].Value != null)
                {
                    pbImage.Image = (Image)dgvEmployee.Rows[e.RowIndex].Cells["imageCol"].Value;
                }
            }
        }
    }
}
