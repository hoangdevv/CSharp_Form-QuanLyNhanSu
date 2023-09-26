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
    public partial class FormAddNewEmployee : Form
    {
        public bool isClose = false;
        public FormAddNewEmployee()
        {
            InitializeComponent();
        }

        bool checkInput()
        {
            if (txtAddNewName.Text == "" || txtAddNewAddress.Text == "" || txtAddNewID.Text == "" 
                || txtAddNewPosition.Text == "" || txtAddNewPay.Text == "" || txtAddNewAllowance.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if(!long.TryParse(txtAddNewPay.Text, out long result) || !long.TryParse(txtAddNewAllowance.Text,out long result2))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số tiền","Cảnh báo",MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {
            cbbAddNewSex.DataSource = Const.listSex;
            cbbAddNewDepartment.DataSource = Const.listDepartment;
            cbbAddNewStatus.DataSource = Const.listStatus;
        }

        private void btnAddNewCancel_Click(object sender, EventArgs e)
        {
            isClose = false;
            this.Close();
        }

        private void btnAddNewSave_Click(object sender, EventArgs e)
        {
            if(!checkInput()) {
                return;
            }
            isClose = true;
            string name = txtAddNewName.Text;
            DateTime birthDay = txtDateAddNewBirthDay.Value;
            string address = txtAddNewAddress.Text;
            string email = txtAddNewEmail.Text;
            string sex = cbbAddNewSex.Text;
            string numberPhone = txtAddNewPhoneNumber.Text;
            string culture = txtAddNewCulture.Text;
            string regular = txtAddNewRegular.Text;

            string employeeID = txtAddNewID.Text;
            string position = txtAddNewPosition.Text;
            long pay = long.Parse(txtAddNewPay.Text);
            string department = cbbAddNewDepartment.Text;
            string status = cbbAddNewStatus.Text;
            long allowance = long.Parse(txtAddNewAllowance.Text);

            //lưu vào biến Const
            Const.newEmployee = new Employee(name, birthDay, address, email, sex, numberPhone, culture,
                regular, employeeID, position, pay, department, status, allowance);

            this.Close();
        }

        private void FormAddNewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
