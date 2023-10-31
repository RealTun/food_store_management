using QLNH.Connect_DB;
using System.Data;
using System.Data.SqlClient;

namespace Form1.Employee.Model
{
    public class EmployeeModel
    {
        Database db = new Database();
        public string? ID_empl { get; set; }
        public string? Name_empl { get; set; }
        public string? Sex { get; set; }
        public string? DateBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
        public int Salary { get; set; }

        public EmployeeModel() { }
        public EmployeeModel(string? id)
        {
            ID_empl = id;
        }
        public EmployeeModel(string? id, string? name, string? sex, string? date, string? numphone, string? role, int salary)
        {
            ID_empl = id;
            Name_empl = name;
            Sex = sex;
            DateBirth = date;
            PhoneNumber = numphone;
            Role = role;
            Salary = salary;
        }

        public void ShowListEmployee(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select * from NHANVIEN";
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public void ShowNameEmployee(ComboBox cb)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select [TenNV] from NHANVIEN";
            DataTable dt = db.ExecuteCommand(cmd);
            cb.DataSource = dt;
            cb.DisplayMember = "TenNV";
        }

        public void GetIdEmployee(TextBox txt, string? name)
        {           
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "select [MaNV] from NHANVIEN where [TenNV] = @name";
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
                DataTable dt = db.ExecuteCommand(cmd);
                txt.Text = dt.Rows[0][0].ToString();
            }
            catch
            {
                
            }
        }

        public bool IsExistedEmployee()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from NHANVIEN where [MaNV] = @id_empl";
            cmd.Parameters.Add("id_empl", SqlDbType.VarChar).Value = ID_empl;
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null)
            {
                if (dt.Rows[0][0].ToString() != "1")
                {
                    return true;
                }
            }
            return false;
        }

        public string CreateEmployee()
        {
            bool isExisted = IsExistedEmployee();
            if (isExisted)
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "insert into NHANVIEN values(@id, @name, @sex, @birth, @phone, @role, @salary)";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_empl;
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = Name_empl;
                cmd.Parameters.Add("sex", SqlDbType.NVarChar).Value = Sex;
                cmd.Parameters.Add("birth", SqlDbType.VarChar).Value = DateBirth;
                cmd.Parameters.Add("phone", SqlDbType.VarChar).Value = PhoneNumber;
                cmd.Parameters.Add("role", SqlDbType.NVarChar).Value = Role;
                cmd.Parameters.Add("salary", SqlDbType.Int).Value = Salary;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            return "Đã tồn tại nhân viên này trong hệ thống!";
        }

        public string UpdateEmployee()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "update NHANVIEN set [TenNV] = @name, [GioiTinh] = @sex, [NgaySinh] = @birth, [Sdt] = @phone, [ChucVu] = @role, [Luong] = @salary where [MaNV] = @id";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_empl;
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = Name_empl;
                cmd.Parameters.Add("sex", SqlDbType.NVarChar).Value = Sex;
                cmd.Parameters.Add("birth", SqlDbType.VarChar).Value = DateBirth;
                cmd.Parameters.Add("phone", SqlDbType.VarChar).Value = PhoneNumber;
                cmd.Parameters.Add("role", SqlDbType.NVarChar).Value = Role;
                cmd.Parameters.Add("salary", SqlDbType.Int).Value = Salary;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch { }
            return "Không thể cập nhật thông tin tại thời điểm này!";
        }

        public string DeleteEmployee()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "delete from NHANVIEN where [MaNV] = @id";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_empl;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch { }
            return "Không thể xóa vào thời điểm này!";
        }
    }
}
