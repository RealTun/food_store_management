using QLNH.Connect_DB;
using System.Data;
using System.Data.SqlClient;

namespace QLNH.Stock
{
    public class StockModel
    {
        Database db = new Database();
        public string? MaNL { set; get; }
        public string? TenNL { set; get; }
        public int DonGia { set; get; }
        public int SoLuong { set; get; }
        public string? HSD { set; get; }

        public StockModel() { }
        public StockModel(string? manl)
        {
            MaNL = manl;
        }
        public StockModel(string? manl, string? tennl, int dg, int sl, string? hsd)
        {
            MaNL = manl;
            TenNL = tennl;
            DonGia = dg;
            SoLuong = sl;
            HSD = hsd;
        }

        public void ShowListStock(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select * from NGUYENLIEU";
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public void ShowListStockByDate(DataGridView dgv, string? date)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select * from NGUYENLIEU where [HSD] = @hsd";
            cmd.Parameters.Add("hsd", SqlDbType.Date).Value = date;
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public bool IsExcisted()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from NGUYENLIEU where [MaNL] = @manl and [HSD] = @hsd";
            cmd.Parameters.Add("manl", SqlDbType.VarChar).Value = MaNL;
            cmd.Parameters.Add("hsd", SqlDbType.Date).Value = HSD;
            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null && dt.Rows.Count == 1)
            {
                if (dt.Rows[0][0].ToString() != "0")
                {
                    return false;
                }
            }
            return true;
        }

        public string CreateStock()
        {
            if(IsExcisted())
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "insert into NGUYENLIEU values(@manl, @tennl, @gia, @sl, @hsd)";
                cmd.Parameters.Add("manl", SqlDbType.VarChar).Value = MaNL;
                cmd.Parameters.Add("tennl", SqlDbType.NVarChar).Value = TenNL;
                cmd.Parameters.Add("gia", SqlDbType.NVarChar).Value = DonGia;
                cmd.Parameters.Add("sl", SqlDbType.NVarChar).Value = SoLuong;
                cmd.Parameters.Add("hsd", SqlDbType.Date).Value = HSD;

                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            else
            {
                return "Đã tồn tại mã nguyên liệu này trong hệ thống";
            }
        }

        public string UpdateStock()
        {
            if (IsExcisted())
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "update NGUYENLIEU set [TenNL] = @tennl, [DonGia] = @gia, [SoLuong] = @sl, [HSD] = @hsd where [MaNL] = @manl";
                cmd.Parameters.Add("manl", SqlDbType.VarChar).Value = MaNL;
                cmd.Parameters.Add("tennl", SqlDbType.NVarChar).Value = TenNL;
                cmd.Parameters.Add("gia", SqlDbType.NVarChar).Value = DonGia;
                cmd.Parameters.Add("sl", SqlDbType.NVarChar).Value = SoLuong;
                cmd.Parameters.Add("hsd", SqlDbType.Date).Value = HSD;

                db.ExecuteCommand(cmd);
                return string.Empty;
            }
            else
            {
                return "Đã tồn tại mã nguyên liệu này trong hệ thống";
            }
        }

        public string DeleteStock()
        {
            try
            {
                var cmd = db.SqlCommandText;
                cmd.CommandText = "delete NGUYENLIEU where [MaNL] = @manl";
                cmd.Parameters.Add("manl", SqlDbType.VarChar).Value = MaNL;
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
