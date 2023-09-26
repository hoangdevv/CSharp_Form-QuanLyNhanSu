using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormUser : Form
    {
        List<string> listAccountType = new List<string>() {"Quản lý","Nhân viên" };
        int index = -1;

        public FormUser()
        {
            InitializeComponent();
        }
        void createDataGridViewUser()
        {
            var userName = new DataGridViewTextBoxColumn();
            var password = new DataGridViewTextBoxColumn();
            var accountType = new DataGridViewCheckBoxColumn();

            userName.DataPropertyName = "User";
            password.DataPropertyName = "Password";
            accountType.DataPropertyName = "AccountType";

            userName.HeaderText = "UserName";
            password.HeaderText = "Password";
            accountType.HeaderText = "AccountType";

            userName.Width = 170;
            password.Width = 150;
            accountType.Width = 100;

            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { userName, password ,accountType});


        }
        void loadDataGridViewUser()
        {
            dataGridViewUser.DataSource = null;
            createDataGridViewUser();
            dataGridViewUser.DataSource = ListAccount.Instance.ListAccounts;
            dataGridViewUser.Refresh();
        }

        bool checkInput()
        {
            for(int i = 0;i < ListAccount.Instance.ListAccounts.Count; i++)
            {
                if(txtUserAccount.Text == ListAccount.Instance.ListAccounts[i].User)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if(txtUserAccount.Text =="" || txtUserPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            loadDataGridViewUser();
            cbbUserAccountType.DataSource = listAccountType; 

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            txtUserAccount.Text = ListAccount.Instance.ListAccounts[index].User; 
            txtUserPassword.Text = ListAccount.Instance.ListAccounts[index].Password;
            switch (ListAccount.Instance.ListAccounts[index].AccountType) 
            {
                case true:
                    {
                        cbbUserAccountType.Text = "Quản lý";
                        break;
                    }
                case false:
                    {
                        cbbUserAccountType.Text = "Nhân viên";
                        break;
                    }
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
            string userName = txtUserAccount.Text;
            string password = txtUserPassword.Text;
            bool accountType = false;

            switch (cbbUserAccountType.Text)
            {
                case "Quản lý":
                    {
                        accountType = true;
                        break;
                    }
                case "Nhân viên":
                    {
                        accountType = false;
                        break;
                    }
            }
            ListAccount.Instance.ListAccounts.Add(new Account(userName, password, accountType));
            loadDataGridViewUser();

            }
            else
            {
                return;
            }
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn hàng để thực hiện!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            string userName = txtUserAccount.Text;
            string password = txtUserPassword.Text;
            bool accountType = false;

            switch (cbbUserAccountType.Text)
            {
                case "Quản lý":
                    {
                        accountType = true;
                        break;
                    }
                case "Nhân viên":
                    {
                        accountType = false;
                        break;
                    }
            }
            ListAccount.Instance.ListAccounts[index].User = userName;
            ListAccount.Instance.ListAccounts[index].Password = password;
            ListAccount.Instance.ListAccounts[index].AccountType = accountType;

            loadDataGridViewUser();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn hàng để thực hiện!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (ListAccount.Instance.ListAccounts[index].AccountType == true)
            {
                MessageBox.Show("Bạn không có quyền xóa tài khoản quản lý", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa!", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    ListAccount.Instance.ListAccounts.RemoveAt(index);
                    loadDataGridViewUser();
                    return;
                }
            }
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
