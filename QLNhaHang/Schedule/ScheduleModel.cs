using System.Data;
using System.Data.SqlClient;
using QLNH.Connect_DB;

namespace QLNH.Schedule
{
    public class ScheduleModel
    {
        Database db = new Database();
        public string? MaNV { get; set; }
        public int Ca { get; set; }
        public string? NgayLam { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }   

        public ScheduleModel() { }
        public ScheduleModel(string? id, string? date)
        {
            MaNV = id;
            NgayLam = date;
        }
        public ScheduleModel(int month, int year)
        {
            Month = month;
            Year = year;
        }

        public ScheduleModel(string? id, int ca, string? date)
        {
            MaNV = id;
            Ca = ca;
            NgayLam = date;
        }

        public void ShowListSchedule(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select LL.MaNV, NV.TenNV, LL.Ca, LL.NgayLam from NHANVIEN NV, LICHLAM LL where NV.MaNV = LL.MaNV";
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public void ShowListScheduleByName(DataGridView dgv, string? name)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select LL.MaNV, NV.TenNV, LL.Ca, LL.NgayLam from NHANVIEN NV, LICHLAM LL where NV.MaNV = LL.MaNV and NV.TenNV = @name";
            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public void ShowSalary(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select BL.TenNV, BL.SoNgay, BL.SoNgay*BL.Luong as Luong " +
                            "from (select LL.MaNV, NV.TenNV, NV.Luong, count(day(LL.NgayLam)) as SoNgay " +
                                "from NHANVIEN NV inner join LICHLAM LL on NV.MaNV = LL.MaNV " +
                                "where month(NgayLam) = @month and year(NgayLam) = @year " +
                                "group by LL.MaNV, NV.TenNV, NV.Luong) as BL";
            cmd.Parameters.Add("month", SqlDbType.Int).Value = Month;
            cmd.Parameters.Add("year", SqlDbType.Int).Value = Year;
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public string CreateSchedule()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "insert into LICHLAM values(@manv, @ca, @ngay)";
                cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = MaNV;
                cmd.Parameters.Add("ca", SqlDbType.Int).Value = Ca;
                cmd.Parameters.Add("ngay", SqlDbType.Date).Value = NgayLam;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch(SqlException e)
            {
                return e.Message;
            }
        }

        public string UpdateSchedule()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "update LICHLAM set [Ca] = @ca where [MaNV] = @manv and [NgayLam] = @ngay";
                cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = MaNV;
                cmd.Parameters.Add("ca", SqlDbType.Int).Value = Ca;
                cmd.Parameters.Add("ngay", SqlDbType.Date).Value = NgayLam;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch (SqlException e)
            {
                return e.Message;
            }
        }

        public string DeleteSchedule()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "delete LICHLAM where [MaNV] = @manv and [NgayLam] = @ngay";
                cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = MaNV;
                cmd.Parameters.Add("ngay", SqlDbType.Date).Value = NgayLam;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch(SqlException e)
            {
                return e.Message;
            }
        }
    }
}
