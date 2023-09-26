using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyNhanSu
{
    public partial class FormEditEmployee : Form
    {
        public bool isClose = false;
        public FormEditEmployee()
        {
            InitializeComponent();
        }

        bool checkInput()
        {
            if (txtEditName.Text == "" || txtEditAddress.Text == "" || txtEditID.Text == ""
                || txtEditPosition.Text == "" || txtEditPay.Text == "" || txtEditAllowance.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!long.TryParse(txtEditPay.Text, out long result) || !long.TryParse(txtEditAllowance.Text, out long result2))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số tiền", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        void LoadEditEmployee()
        {
            txtEditName.Text = Const.newEmployee.EmployeeName;
            txtDateEditBirthDay.Value = Const.newEmployee.BirthDay;
            txtEditAddress.Text = Const.newEmployee.Address;
            txtEditEmail.Text = Const.newEmployee.Email;
            cbbEditSex.Text = Const.newEmployee.Sex;
            txtEditPhoneNumber.Text = Const.newEmployee.NumberPhone;
            txtEditCulture.Text = Const.newEmployee.Culture;
            txtEditRegular.Text = Const.newEmployee.Regular;

            txtEditID.Text = Const.newEmployee.EmployeeID;
            txtEditPosition.Text = Const.newEmployee.Position;
            txtEditPay.Text = Const.newEmployee.Pay.ToString();
            cbbEditDepartment.Text = Const.newEmployee.Department;
            cbbEditStatus.Text = Const.newEmployee.Status;
            txtEditAllowance.Text = Const.newEmployee.Allowance.ToString();
        }
        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            cbbEditSex.DataSource = Const.listSex;
            cbbEditDepartment.DataSource = Const.listDepartment;
            cbbEditStatus.DataSource = Const.listStatus;
            LoadEditEmployee();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
            isClose = true;
            string name = txtEditName.Text;
            DateTime birthDay = txtDateEditBirthDay.Value;
            string address = txtEditAddress.Text;
            string email = txtEditEmail.Text;
            string sex = cbbEditSex.Text;
            string numberPhone = txtEditPhoneNumber.Text;
            string culture = txtEditCulture.Text;
            string regular = txtEditRegular.Text;

            string employeeID = txtEditID.Text;
            string position = txtEditPosition.Text;
            long pay = long.Parse(txtEditPay.Text);
            string department = cbbEditDepartment.Text;
            string status = cbbEditStatus.Text;
            long allowance = long.Parse(txtEditAllowance.Text);

            Const.newEmployee = new Employee(name, birthDay, address, email, sex, numberPhone, culture,
                regular, employeeID, position, pay, department, status, allowance);
            this.Close();
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            isClose = false;
            this.Close();
        }
    }
}
