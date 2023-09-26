using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormDepartment : Form
    {
        int index = -1;
        public FormDepartment()
        {
            InitializeComponent();
        }

        void loadListView()
        {
            listBoxDepartment.DataSource = null;
            listBoxDepartment.DataSource = Const.listDepartment;
        }

        bool checkDepartment()
        {
            if(Const.listDepartment.Contains(txtDepartment.Text))
            {
                MessageBox.Show("Tên phòng ban đã có!", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            loadListView();
        }

        private void listBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxDepartment.SelectedIndex;
            if(index < 0)
            {
                return;
            }
            txtDepartment.Text = Const.listDepartment[index] ;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (checkDepartment())
            {
                string department = txtDepartment.Text;
                Const.listDepartment.Add(department);
                loadListView();
            }
           
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            if (checkDepartment())
            {
                string department = txtDepartment.Text;
                Const.listDepartment[index] = department;
                loadListView();
            }
            
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa!", "Thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Const.listDepartment.RemoveAt(index);
                loadListView();
            }
        }

        private void btnCancelDepartment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
