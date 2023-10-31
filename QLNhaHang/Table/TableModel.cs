using QLNH.Connect_DB;
using System.Data;
using System.Data.SqlClient;

namespace QLNH.Table
{
    public class TableModel
    {
        Database db = new Database();
        public string? MaBan { set; get; }
        public string? TenBan { set; get; }
        public string? LoaiBan { set; get; }

        public TableModel() { }
        public TableModel(string? mb)
        {
            MaBan = mb;
        }

        public TableModel(string? mb, string? tb, string? lb)
        {
            MaBan = mb;
            TenBan = tb;
            LoaiBan = lb;
        }

        public void ShowListTable(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select * from BAN";
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public void ListOrderTable(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select NV_BAN.MaBan, BAN.TenBan, NV_BAN.TenKH, NV_BAN.Sdt, NV_BAN.Thoigian " +
                        "from BAN inner join NV_BAN ON BAN.MaBan = NV_BAN.MaBan";
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public void ListOrderTableByDate(DataGridView dgv, int day, int month, int year)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select NB.MaBan, B.TenBan, NB.TenKH, NB.Sdt, NB.Thoigian " +
                "from BAN B inner join NV_BAN NB on B.MaBan = NB.MaBan " +
                "where day(NB.Thoigian) = @day and month(NB.Thoigian) = @month and year(NB.Thoigian) = @year";
            cmd.Parameters.Add("day", SqlDbType.Int).Value = day;
            cmd.Parameters.Add("month", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("year", SqlDbType.Int).Value = year;
            
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public void GetIdTable(TextBox txt, string? name)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select [MaBan] from BAN where [TenBan] = @name";
            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
            DataTable dt = db.ExecuteCommand(cmd);
            txt.Text = dt.Rows[0][0].ToString();
        }

        public string CreateOrderTable(string? mb, string? manv, string? kh, string? sdt, string? tg)
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "insert into NV_BAN values(@mb, @manv, @kh, @sdt, @tg)";
                cmd.Parameters.Add("mb", SqlDbType.VarChar).Value = mb;
                cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = manv;
                cmd.Parameters.Add("kh", SqlDbType.NVarChar).Value = kh;
                cmd.Parameters.Add("sdt", SqlDbType.VarChar).Value = sdt;
                cmd.Parameters.Add("tg", SqlDbType.DateTime).Value = tg;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch (SqlException e)
            {
                return e.Message;
            }
        }

        public string DeleteOrderTable(string? mb)
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "delete NV_BAN where [MaBan] = @mb";
                cmd.Parameters.Add("mb", SqlDbType.VarChar).Value = mb;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch (SqlException e)
            {
                return e.Message;
            }
        }

        public string CreateTable()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "insert into BAN values(@mb, @tb, @lb)";
                cmd.Parameters.Add("mb", SqlDbType.VarChar).Value = MaBan;
                cmd.Parameters.Add("tb", SqlDbType.NVarChar).Value = TenBan;
                cmd.Parameters.Add("lb", SqlDbType.NVarChar).Value = LoaiBan;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch (SqlException e)
            {
                return e.Message;
            }
        }

        public string UpdateTable()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "update BAN set [TenBan] = @tb, [LoaiBan] = @lb where [MaBan] = @mb";
                cmd.Parameters.Add("mb", SqlDbType.VarChar).Value = MaBan;
                cmd.Parameters.Add("tb", SqlDbType.NVarChar).Value = TenBan;
                cmd.Parameters.Add("lb", SqlDbType.NVarChar).Value = LoaiBan;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch (SqlException e)
            {
                return e.Message;
            }
        }

        public string DeleteTable()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "delete BAN where [MaBan] = @mb";
                cmd.Parameters.Add("mb", SqlDbType.VarChar).Value = MaBan;
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch (SqlException e)
            {
                return e.Message;
            }
        }
    }
}
