using System.Data.SqlClient;
using System.Data;
using QLNH.Connect_DB;

namespace Form1.Bill.Model
{
    public class BillModel
    {
        Database db = new Database();
        public string? ID_order { get; set; }
        public string? NameCustomer { get; set; }
        public double Total { get; set; }
        public string? TimeBill { get; set; }
        public string? Voucher { get; set; }
        public string? ID_Employee { get; set; }
        public BillModel() 
        {
            
        }

        public BillModel(string id, string voucher)
        {
            ID_order = id;
            Voucher = voucher;
        }

        public BillModel(string id, string namecus, double total, string timeorder, string? id_em) 
        {
            ID_order = id;
            NameCustomer = namecus;
            Total = total;
            TimeBill = timeorder;
            ID_Employee = id_em;
        }

        public void AddBill()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "insert into HoaDon values(@id, @namecus, @total, @timeorder, @idnv)";
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_order;
            cmd.Parameters.Add("namecus", SqlDbType.NVarChar).Value = NameCustomer;
            cmd.Parameters.Add("total", SqlDbType.Float).Value = Total;
            cmd.Parameters.Add("timeorder", SqlDbType.SmallDateTime).Value = TimeBill;
            cmd.Parameters.Add("idnv", SqlDbType.VarChar).Value = ID_Employee;

            db.ExecuteCommand(cmd);
        }

        public void AddBillVoucher()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "insert into HD_KM values(@id, @voucher)";
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = ID_order;
            cmd.Parameters.Add("voucher", SqlDbType.VarChar).Value = Voucher;
            db.ExecuteCommand(cmd);
        }

        public void DeleteBill(string? MaHD)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "Delete HoaDon where [MaHD] = @MaHD";
            cmd.Parameters.Add("MaHD", SqlDbType.VarChar).Value = MaHD;
            db.ExecuteCommand(cmd);           
        }

        public void DeleteBillVoucher(string? MaHD)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "delete HD_KM where [MaHD] = @MaHD";
            cmd.Parameters.Add("MaHD", SqlDbType.VarChar).Value = MaHD;
            db.ExecuteCommand(cmd);
        }

        public void DeleteDetailsBill(string? MaHD)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "delete ChiTietHD where [MaHD] = @MaHD";
            cmd.Parameters.Add("MaHD", SqlDbType.VarChar).Value = MaHD;
            db.ExecuteCommand(cmd);
        }

        public void AutoNumberBill()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select max(MaHD+1) from HoaDon";
            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null && dt.Rows.Count == 1)
            {
                ID_order = dt.Rows[0][0].ToString();
            }
            else
            {
                ID_order = "1";
            }
        }
    }
}
