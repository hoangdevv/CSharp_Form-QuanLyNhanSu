using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    internal class Const
    {
        public static Employee newEmployee = null; // tạo biến trung gian để lưu , kiểu dữ liệu:Employee
        public static bool accountType; // phân quyền tài khoản

        public static List<string> listDepartment = new List<string>() { "IT", "Marketing", "Kế toán","BA"};
        public static List<string> listSex = new List<string>() {"Nam", "Nữ"};
        public static List<string> listStatus = new List<string>() {"Đang làm việc", "Đã nghỉ"};
    }
}
