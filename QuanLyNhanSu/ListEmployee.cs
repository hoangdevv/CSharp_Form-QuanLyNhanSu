using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    internal class ListEmployee
    {
        private static ListEmployee instance;

        internal static ListEmployee Instance {
            get { 
                if (instance == null)
                    instance = new ListEmployee();
                return instance; 
            }
            set => instance = value; 
        }

        List<Employee> listEmployees = new List<Employee>();
        public List<Employee> ListEmployees { get => listEmployees; set => listEmployees = value; }
        public ListEmployee() 
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee("Huy Hoàng", new DateTime(2003, 6, 28), "Q9", "nvhhoang286@gmail.com", "Nam", "0122313", "Tốt", "CNPM", "01", "Giám đốc", 1000000, "Ban CNTT", "Đang làm việc", 120000));  
            listEmployees.Add(new Employee("Thu Thảo", new DateTime(2002, 6, 28), "Q9", "", "Nữ", "0122314", "", "CNPM", "02", "Quản lý", 2000000, "Ban CNTT", "Đang làm việc", 120000));  
            listEmployees.Add(new Employee("Chiến Mai", new DateTime(2005, 6, 28), "Q8", "", "Nữ", "0122315", "Tốt", "CNPM", "03", "Giám đốc", 3000000, "Ban CNTT", "Đã nghỉ", 120000));  
            listEmployees.Add(new Employee("Hoàng Dũng", new DateTime(2006, 6, 28), "Q7", "", "Nam", "0122316", "", "CNPM", "04", "Nhân viên", 4000000, "Ban CNTT", "Đang làm việc", 120000));  
            listEmployees.Add(new Employee("Yến Mai", new DateTime(1998, 6, 28), "Q6", "", "Nữ", "0122317", "", "CNPM", "05", "Trưởng phòng", 5000000, "Ban CNTT", "Đang làm việc", 120000));  
            listEmployees.Add(new Employee("Châu Dũng", new DateTime(2000, 6, 28), "Q8", "", "Nam", "0122318", "Tốt", "CNPM", "06", "Marketing", 6000000, "Ban CNTT", "Đã nghỉ", 120000));  
            listEmployees.Add(new Employee("Nam Hoàng", new DateTime(2001, 6, 28), "Q4", "", "Nam", "0122319", "", "CNPM", "07", "Nhân viên", 7000000, "Ban CNTT", "Đang làm việc", 120000));  
            listEmployees.Add(new Employee("Thành Danh", new DateTime(2002, 6, 28), "Q2", "", "Nam", "0122321", "Tốt", "CNPM", "08", "Giám đốc", 1000000, "Ban CNTT", "Đã nghỉ", 120000));
        }
    }
}
