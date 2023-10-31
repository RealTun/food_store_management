using System.Data.SqlClient;
using System.Data;
using QLNH.Connect_DB;

namespace Form1.Bill.Model
{
    public class BillInfo
    {
        Database db = new Database();
        public string? ID_order { get; set; }
        public string? NameCus { get; set; }
        public string? Total { get; set; }
        public string? TimeOrder { get; set; }
        public string? Voucher { get; set; }
        public string? NameEmpl { get; set; }
        public BillInfo()
        {

        }

        public void ShowListBills(DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select MaHD, TenKH, SoTien, ThoiGian from HoaDon";
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }

        public bool IsExistedBill(string id_order)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from HoaDon where [MaHD] = @id_order";
            cmd.Parameters.Add("id_order", SqlDbType.VarChar).Value = id_order;
            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null && dt.Rows.Count == 1)
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    return true;     
                }
            }
            return false;
        }

        public bool IsExistedBillVoucher(string? id_order)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from HD_KM where MaHD = @id";
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id_order;
            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null && dt.Rows.Count == 1)
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    return true;
                }
            }
            return false;
        }

        public void GetInfoBill(string? id_order)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select HD.MaHD, NV.TenNV, HD.TenKH, HD.SoTien, HD.ThoiGian " +
                        "from HoaDon HD inner join NHANVIEN NV on HD.MaNV = NV.MaNV " +
                        "Where HD.MaHD = @id_order";
            cmd.Parameters.Add("id_order", SqlDbType.VarChar).Value = id_order;
            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null)
            {
                ID_order = dt.Rows[0][0].ToString();
                NameCus = dt.Rows[0][2].ToString();
                Total = dt.Rows[0][3].ToString();
                TimeOrder = dt.Rows[0][4].ToString();
                NameEmpl = dt.Rows[0][1].ToString();
            }

            if(IsExistedBillVoucher(id_order))
            {
                cmd = db.SqlCommandText;
                cmd.CommandText = "select MaKM from HD_KM where [MaHD] = @id";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id_order;
                dt = db.ExecuteCommand(cmd);
                if (dt != null)
                {
                    Voucher = dt.Rows[0][0].ToString();
                }
            }
        }

        public void ShowDetailsBill(string? id_order, DataGridView dgv)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select distinct TenMon, CT.SoLuong as SoLuong, I.DonGia as DonGia, I.DonGia*CT.SoLuong as TongTien from ChiTietHD CT, HoaDon HD, InfoFood I where CT.MaHD = @id_order and CT.MaMon = I.MaMon";
            cmd.Parameters.Add("id_order", SqlDbType.VarChar).Value = id_order;
            DataTable dt = db.ExecuteCommand(cmd);
            dgv.DataSource = dt;
        }
    }
}
