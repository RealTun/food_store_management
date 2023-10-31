using System.Data.SqlClient;
using System.Data;
using QLNH.Connect_DB;

namespace Form1.Bill.Model
{
    public class BillDetails
    {
        Database db = new Database();
        public string? Id_order { set; get; }
        public string? Id_food { set; get; }
        public int Amount { set; get; }

        public BillDetails() { }
        public BillDetails(string id_or, int amount) 
        {
            Id_order = id_or;
            Amount = amount;
        }

        public void GetID_Food(string nameFood)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select MaMon from InfoFood where [TenMon] = @nameFood";
            cmd.Parameters.Add("nameFood", SqlDbType.NVarChar).Value = nameFood;
            
            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null)
            {
                Id_food = dt.Rows[0][0].ToString();
            }
        }

        public void AddDetailsBill()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "insert into ChiTietHD values(@id_order, @id_food, @amount)";
            cmd.Parameters.Add("id_order", SqlDbType.VarChar).Value = Id_order;
            cmd.Parameters.Add("id_food", SqlDbType.NVarChar).Value = Id_food;
            cmd.Parameters.Add("amount", SqlDbType.Int).Value = Amount;

            db.ExecuteCommand(cmd);
        }
    }
}
