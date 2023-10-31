using DevExpress.XtraReports.Design;
using QLNH.Connect_DB;
using System.Data;
using System.Data.SqlClient;

namespace Form1.MonAn.Model
{
    public class Food
    {
        Database db = new Database();
        public string? idFood { get; set; }
        public string? nameFood { get; set; }
        public string? priceFood { get; set; }
        public string? dateUpdate { get; set; }


        public void ShowListFood(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select * from InfoFood";
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public bool IsFoodExisted()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from InfoFood where [MaMon] = @idFood";
            cmd.Parameters.Add("idFood", SqlDbType.VarChar).Value = idFood;
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null)
            {
                if (dt.Rows[0][0].ToString() != "0")
                {
                    return true;
                }
            }
            return false;
        }

        public string AddFood()
        {
            var IsExisted = IsFoodExisted();
            if (IsExisted)
            {
                return "Món ăn đã có trong danh sách!";
            }

            var cmd = db.SqlCommandText;

            cmd.CommandText = "insert into InfoFood values(@idfood, @namefood, @pricefood, @datefood)";
            cmd.Parameters.Add("idfood", SqlDbType.VarChar).Value = idFood;
            cmd.Parameters.Add("namefood", SqlDbType.NVarChar).Value = nameFood;
            cmd.Parameters.Add("pricefood", SqlDbType.Int).Value = priceFood;
            cmd.Parameters.Add("datefood", SqlDbType.NVarChar).Value = dateUpdate;

            db.ExecuteCommand(cmd);

            return string.Empty;
        }

        public string UpdateFood()
        {
            var cmd = db.SqlCommandText;

            cmd.CommandText = "update InfoFood set [TenMon] = @namefood, [DonGia] = @pricefood, [ThoiGian] = @datefood where [MaMon] = @id_update";
            cmd.Parameters.Add("namefood", SqlDbType.NVarChar).Value = nameFood;
            cmd.Parameters.Add("pricefood", SqlDbType.Int).Value = priceFood;
            cmd.Parameters.Add("datefood", SqlDbType.NVarChar).Value = dateUpdate;
            cmd.Parameters.Add("id_update", SqlDbType.VarChar).Value = idFood;

            db.ExecuteCommand(cmd);

            return string.Empty;
        }

        public string DeleteFood()
        {
            var cmd = db.SqlCommandText;

            cmd.CommandText = "delete from InfoFood where [MaMon] = @id_delete";
            cmd.Parameters.Add("id_delete", SqlDbType.VarChar).Value = idFood;

            db.ExecuteCommand(cmd);

            return string.Empty;
        }
    }
}
