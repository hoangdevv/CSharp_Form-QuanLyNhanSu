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
    public partial class FormShowView : Form
    {
        public FormShowView()
        {
            InitializeComponent();
        }

        void loadShowView()
        {
                txtName.Text = Const.newEmployee.EmployeeName;
                txtBirthDay.Value = Const.newEmployee.BirthDay;
                txtAddress.Text = Const.newEmployee.Address;
                txtEmail.Text = Const.newEmployee.Email;
                txtSex.Text = Const.newEmployee.Sex;
                txtPhoneNumber.Text = Const.newEmployee.NumberPhone;
                txtCulture.Text = Const.newEmployee.Culture;
                txtRegular.Text = Const.newEmployee.Regular;

                txtID.Text = Const.newEmployee.EmployeeID;
                txtPosition.Text = Const.newEmployee.Position;
                txtPay.Text = Const.newEmployee.Pay.ToString();
                txtDepartment.Text = Const.newEmployee.Department;
                txtStatus.Text = Const.newEmployee.Status;
                txtAllowance.Text = Const.newEmployee.Allowance.ToString();
        }

        private void FormShowView_Load(object sender, EventArgs e)
        {
            loadShowView();
        }

        private void btnAddNewCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
