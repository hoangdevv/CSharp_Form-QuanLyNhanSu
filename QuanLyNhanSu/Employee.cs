using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class Employee
    {
        private string employeeName;
        private DateTime birthDay;
        private string address;
        private string email;
        private string sex;
        private string numberPhone;
        private string culture;
        private string regular;

        private string employeeID;
        private string position;
        private long pay;
        private string department;
        private string status;
        private long allowance;

        public Employee()
        {
        }

        public Employee(string employeeName, DateTime birthDay, string address, 
            string email, string sex, string numberPhone, string culture,
            string regular, string employeeID, string position, long pay, 
            string department, string status, long allowance)
        {
            this.employeeName = employeeName;
            this.birthDay = birthDay;
            this.address = address;
            this.email = email;
            this.sex = sex;
            this.numberPhone = numberPhone;
            this.culture = culture;
            this.regular = regular;
            this.employeeID = employeeID;
            this.position = position;
            this.pay = pay;
            this.department = department;
            this.status = status;
            this.allowance = allowance;
        }

        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Sex { get => sex; set => sex = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public string Culture { get => culture; set => culture = value; }
        public string Regular { get => regular; set => regular = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Position { get => position; set => position = value; }
        public long Pay { get => pay; set => pay = value; }
        public string Department { get => department; set => department = value; }
        public string Status { get => status; set => status = value; }
        public long Allowance { get => allowance; set => allowance = value; }
    }
}
