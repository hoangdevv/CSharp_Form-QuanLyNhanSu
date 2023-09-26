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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Method

        bool checkAccount(string user, string password)
        {
            for(int i = 0;i < ListAccount.Instance.ListAccounts.Count; i++)
            {
               if(txtLoginAccount.Text == ListAccount.Instance.ListAccounts[i].User && txtLoginPassword.Text == ListAccount.Instance.ListAccounts[i].Password)
                {
                    Const.accountType = ListAccount.Instance.ListAccounts[i].AccountType;
                    return true;
                }
            }
            return false;
        }

        void clearInput()
        {
            foreach(var item in this.Controls)
            {
                TextBox itemtxb = item as TextBox;
                if(itemtxb != null)
                {
                    itemtxb.Clear();
                    txtLoginAccount.Focus();
                }
            }
        }

        #endregion

        #region Event
        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtLoginAccount.Text = "huyhoang";
            txtLoginPassword.Text = "123456";

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (checkAccount(txtLoginAccount.Text, txtLoginPassword.Text))
            {
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
                formMain.logout += FormMain_logout;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK);
                txtLoginAccount.Focus();
            }

            clearInput();
        }

        private void FormMain_logout(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CheckboxLoginDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckboxLoginDisplay.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = false;
            }
            if(!CheckboxLoginDisplay.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion
    }
}
