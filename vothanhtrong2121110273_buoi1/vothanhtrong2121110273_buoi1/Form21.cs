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
    public partial class Form21 : Form
    {

        public Form21()
        {
            InitializeComponent();
        }

        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();

            Employee em = new Employee();
            em.Id = "1";
            em.Name = "Thanh Trọng";
            em.Age = 20;
            em.Gender = true;
            lst.Add(em);

            em = new Employee();
            em.Id = "2";
            em.Name = "Thanh Minh";
            em.Age = 21;
            em.Gender = true;
            lst.Add(em);

            em = new Employee();
            em.Id = "3";
            em.Name = "Thanh Nga";
            em.Gender = false;
            em.Age = 22;
            lst.Add(em);

            return lst;
        }
        List<Employee> lst;
        private void Form21_Load(object sender, EventArgs e)
        {
            lst = GetData();

            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age);
            }
        }
        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = tbAge.TextLength;
            em.Gender = ckGender.Checked;

            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
            tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;
            lst.RemoveAt(idx);
            dgvEmployee.Rows.RemoveAt(idx);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
