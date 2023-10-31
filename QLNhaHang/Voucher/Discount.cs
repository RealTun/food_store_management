using QLNH.Connect_DB;
using System.Data;
using System.Data.SqlClient;

namespace QLNH.Voucher
{
    public class Discount
    {
        Database db = new Database();
        public string? MaKM { get; set; }
        public string? TenKM { get; set; }
        public int Giatri { get; set; }
        public string? ThgianBD { get; set; }
        public string? ThgianKT { get; set; }

        public string? Today { get; set; }

        public Discount() { }

        public Discount(string? maKM)
        {
            MaKM = maKM;
        }

        public Discount(string? maKM, string? today)
        {
            MaKM = maKM;
            Today = today;
        }

        public Discount(string? maKM, string? tenKM, int gt, string? thgianBD, string? thgianKT)
        {
            MaKM = maKM;
            TenKM = tenKM;
            Giatri = gt;
            ThgianBD = thgianBD;
            ThgianKT = thgianKT;
        }

        public void ShowListDiscount(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "Select * from KHUYENMAI";
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public bool IsExcisted()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from KHUYENMAI where [MaKM] = @makm and [ThoigianBD] <= @today and [ThoigianKT] >= @today";
            cmd.Parameters.Add("makm", SqlDbType.VarChar).Value = MaKM;
            cmd.Parameters.Add("today", SqlDbType.VarChar).Value = Today;
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            return false;
        }

        public int GetValueDiscount()
        {
            if(IsExcisted())
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "select [Giatri] from KHUYENMAI where [MaKM] = @makm";
                cmd.Parameters.Add("makm", SqlDbType.VarChar).Value = MaKM;
                DataTable dt = db.ExecuteCommand(cmd);
                if(dt != null && dt.Rows.Count == 1)
                {
                    return Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
            return 0;
        }

        public string AddDiscount()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "insert into KHUYENMAI values(@maKM, @tenKM, @gt, @bd, @kt)";
                cmd.Parameters.Add("maKM", SqlDbType.VarChar).Value = MaKM;
                cmd.Parameters.Add("tenKM", SqlDbType.NVarChar).Value = TenKM;
                cmd.Parameters.Add("gt", SqlDbType.Int).Value = Giatri;
                cmd.Parameters.Add("bd", SqlDbType.Date).Value = ThgianBD;
                cmd.Parameters.Add("kt", SqlDbType.Date).Value = ThgianKT;
                
                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch(SqlException e)
            {
                return e.Message;
            }
        }

        public string UpdateDiscount()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "update KHUYENMAI set [TenKM] = @tenKM, [Giatri] = @gt, [ThoigianBD] = @bd, [ThoigianKT] = @kt where [MaKM] = @maKM";
                cmd.Parameters.Add("maKM", SqlDbType.VarChar).Value = MaKM;
                cmd.Parameters.Add("tenKM", SqlDbType.NVarChar).Value = TenKM;
                cmd.Parameters.Add("gt", SqlDbType.Int).Value = Giatri;
                cmd.Parameters.Add("bd", SqlDbType.Date).Value = ThgianBD;
                cmd.Parameters.Add("kt", SqlDbType.Date).Value = ThgianKT;

                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            catch (SqlException e)
            {
                return e.Message;
            }
        }

        public string DeleteDiscount()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "delete KHUYENMAI where [MaKM] = @maKM";
                cmd.Parameters.Add("maKM", SqlDbType.VarChar).Value = MaKM;
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
