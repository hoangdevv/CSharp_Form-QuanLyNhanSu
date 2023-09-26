using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyNhanSu
{
    public partial class FormMain : Form
    {
        public event EventHandler logout;
        public bool isExit =true;
        int index = -1;
        public FormMain()
        {
            InitializeComponent();
        }

        #region Method
        void loadGridViewMain()
        {
            dataGridViewMain.Rows.Clear(); // vì không muốn lấy hết nên dùng row để add, vì vậy phải gọi tới hàm clear thay vì dùng cho grid = null
            foreach(var item in ListEmployee.Instance.ListEmployees)
            {
                dataGridViewMain.Rows.Add(item.EmployeeID,item.EmployeeName,item.Sex,item.BirthDay.ToShortDateString(),item.Position,item.Department,item.Status);
            }
        }

        void Decentralization() //phân quyền
        {
            if (Const.accountType == false)
            {
                tSMIManagerAccount.Enabled = tSMIManagerStaff.Enabled = tSMIManagerDepartment.Enabled  = false;
                ToolStripMenuItemManager.Click += ToolStripMenuItemManager_Click;
            }
            if(Const.accountType == true)
            {
                tSMIManagerStaff.Click += TSMIManagerStaff_Click;
            }
        }

        #endregion Method

        #region Event
        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStripButtonView.Enabled = toolStripButtonAdd.Enabled = toolStripButtonFix.Enabled =toolStripButtonDelete.Enabled = false;
            Decentralization();
            loadGridViewMain();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isExit)
                Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true; return;
                }
            }
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            logout(this, new EventArgs());
        }

        private void ToolStripMenuItemManager_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không có quyền admin", "Thông báo", MessageBoxButtons.OK);
            return;
        }

        private void TSMIManagerStaff_Click(object sender, EventArgs e)
        {
            toolStripButtonView.Enabled = toolStripButtonAdd.Enabled = toolStripButtonFix.Enabled = toolStripButtonDelete.Enabled = true;
        }

        private void tSMIManagerAccount_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.ShowDialog();
        }

        private void tSMIManagerDepartment_Click(object sender, EventArgs e)
        {
            FormDepartment formDepartment = new FormDepartment();
            formDepartment.ShowDialog();
        }
        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            if(index < 0)
            {
                MessageBox.Show("Vui lòng chon bản ghi","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }
            FormShowView formShowView = new FormShowView();
            formShowView.ShowDialog();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddNewEmployee formAddNewEmployee = new FormAddNewEmployee();
            formAddNewEmployee.FormClosed += FormAddNewEmployee_FormClosed;
            formAddNewEmployee.ShowDialog();

        }

        private void FormAddNewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {          
            if((sender as FormAddNewEmployee).isClose)
            {
                  ListEmployee.Instance.ListEmployees.Add(Const.newEmployee);
        loadGridViewMain();
            }
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
            {
                return;
            }


            Const.newEmployee = new Employee();
            Const.newEmployee.EmployeeName = ListEmployee.Instance.ListEmployees[index].EmployeeName;
            Const.newEmployee.BirthDay = ListEmployee.Instance.ListEmployees[index].BirthDay;
            Const.newEmployee.Address = ListEmployee.Instance.ListEmployees[index].Address;
            Const.newEmployee.Email = ListEmployee.Instance.ListEmployees[index].Email;
            Const.newEmployee.Sex = ListEmployee.Instance.ListEmployees[index].Sex;
            Const.newEmployee.NumberPhone = ListEmployee.Instance.ListEmployees[index].NumberPhone;
            Const.newEmployee.Culture = ListEmployee.Instance.ListEmployees[index].Culture;
            Const.newEmployee.Regular = ListEmployee.Instance.ListEmployees[index].Regular;

            Const.newEmployee.EmployeeID = ListEmployee.Instance.ListEmployees[index].EmployeeID;
            Const.newEmployee.Position = ListEmployee.Instance.ListEmployees[index].Position;
            Const.newEmployee.Pay = ListEmployee.Instance.ListEmployees[index].Pay;
            Const.newEmployee.Department = ListEmployee.Instance.ListEmployees[index].Department;
            Const.newEmployee.Status = ListEmployee.Instance.ListEmployees[index].Status;
            Const.newEmployee.Allowance = ListEmployee.Instance.ListEmployees[index].Allowance;
        }
        private void toolStripButtonFix_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chon bản ghi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            FormEditEmployee formEditEmployee = new FormEditEmployee();
            formEditEmployee.FormClosed += FormEditEmployee_FormClosed;
            formEditEmployee.ShowDialog();
        }

        private void FormEditEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if((sender as FormEditEmployee).isClose)
            {
                ListEmployee.Instance.ListEmployees[index].EmployeeName = Const.newEmployee.EmployeeName;
                ListEmployee.Instance.ListEmployees[index].BirthDay = Const.newEmployee.BirthDay;
                ListEmployee.Instance.ListEmployees[index].Address = Const.newEmployee.Address;
                ListEmployee.Instance.ListEmployees[index].Email = Const.newEmployee.Email;
                ListEmployee.Instance.ListEmployees[index].Sex = Const.newEmployee.Sex;
                ListEmployee.Instance.ListEmployees[index].NumberPhone = Const.newEmployee.NumberPhone;
                ListEmployee.Instance.ListEmployees[index].Culture = Const.newEmployee.Culture;
                ListEmployee.Instance.ListEmployees[index].Regular = Const.newEmployee.Regular;

                ListEmployee.Instance.ListEmployees[index].EmployeeID = Const.newEmployee.EmployeeID;
                ListEmployee.Instance.ListEmployees[index].Position = Const.newEmployee.Position;
                ListEmployee.Instance.ListEmployees[index].Pay = Const.newEmployee.Pay;
                ListEmployee.Instance.ListEmployees[index].Department = Const.newEmployee.Department;
                ListEmployee.Instance.ListEmployees[index].Status = Const.newEmployee.Status;
                ListEmployee.Instance.ListEmployees[index].Allowance = Const.newEmployee.Allowance;
                loadGridViewMain();
            }
        }
        #endregion Event

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chon bản ghi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa!", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
            ListEmployee.Instance.ListEmployees.RemoveAt(index);
            loadGridViewMain();
            }
        }
    }
}
