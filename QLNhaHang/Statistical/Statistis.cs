using QLNH.Connect_DB;
using System.Data;
using System.Data.SqlClient;

namespace QLNH.Statistical
{
    public class Statistis
    {
        Database db = new Database();
        public int TotalCustomer { get; set; }
        public int TotalBill { get; set; }
        public int Revenue { get; set; }

        public int Profit { get; set; }
        public string? DateStart {get; set; }
        public string? DateEnd { get; set; }

        public Statistis() { }

        public Statistis(string? start, string? end)
        {
            DateStart = start;
            DateEnd = end;
        }

        public void GetTotalCustomer()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from HoaDon";
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null && dt.Rows.Count == 1)
            {
                TotalCustomer = Convert.ToInt32(dt.Rows[0][0]);
            }
        }

        public void GetTotalCustomerByDate()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from (SELECT  MaHD, SoTien, CONVERT(date, ThoiGian, 101) as ThoiGian from  HoaDon) as GetDateBill " +
                               "where GetDateBill.ThoiGian >= @dateStart and GetDateBill.ThoiGian <= @dateEnd";

            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = DateEnd;
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null && dt.Rows.Count == 1)
            {
                TotalCustomer = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }

        public void GetTotalBill()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count([MaHD]) from HoaDon";
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null && dt.Rows.Count == 1)
            {
                TotalBill = Convert.ToInt32(dt.Rows[0][0]);
            }
        }

        public void GetTotalBillByDate()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(MaHd) from (SELECT  MaHD, SoTien, CONVERT(date, ThoiGian, 101) as ThoiGian from  HoaDon) as GetDateBill " +
                               "where GetDateBill.ThoiGian >= @dateStart and GetDateBill.ThoiGian <= @dateEnd";

            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = DateEnd;
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null && dt.Rows.Count == 1)
            {
                TotalBill = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }

        public void GetRevenue()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select sum([SoTien]) from HoaDon";
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null && dt.Rows.Count == 1)
            {
                if (dt.Rows[0].IsNull(0))
                {
                    Revenue = 0;
                }
                else
                {
                    Revenue = Convert.ToInt32(dt.Rows[0][0]);
                }
            }
        }

        public void GetRevenueByDate()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select sum(GetDateBill.SoTien) as Revenue from (SELECT  MaHD, SoTien, CONVERT(date, ThoiGian, 101) as ThoiGian from  HoaDon) as GetDateBill " +
                              "where GetDateBill.ThoiGian >= @dateStart and GetDateBill.ThoiGian <= @dateEnd";
            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = DateEnd;

            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null && dt.Rows.Count == 1)
            {
                if (dt.Rows[0].IsNull(0))
                {
                    Revenue = 0;
                }
                else
                {
                    Revenue = Convert.ToInt32(dt.Rows[0][0]);
                }               
            }
        }

        public void GetTop5(Label lb)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select Top 5 F.TenMon, SUM(CT.SoLuong) as SoTien " +
                            "from ChiTietHD CT, InfoFood F " +
                            "where CT.MaMon = F.MaMon " +
                            "group by F.TenMon " +
                            "order by SoTien DESC";
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lb.Text += row[0].ToString() + "\n";
                }
            }
        }

        public void GetTop5ByDate(Label lb)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select Top 5 GetDateBill.TenMon ,sum(GetDateBill.SoLuong) as SoLuong " +
                            "from (SELECT CT.MaMon, F.TenMon, CT.SoLuong, CONVERT(date, HD.ThoiGian, 101) as ThoiGian from  HoaDon HD, ChiTietHD CT, InfoFood F where HD.MaHD = CT.MaHD and CT.MaMon = F.MaMon) as GetDateBill " +
                            "where GetDateBill.ThoiGian >= @dateStart and GetDateBill.ThoiGian <= @dateEnd " +
                            "group by GetDateBill.TenMon " +
                            "order by SoLuong DESC";
            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = DateEnd;

            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lb.Text += row[0].ToString() + "\n";
                }
            }
        }

        public void GetProfit()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select sum(TienLai.Lai) " +
                            "from (select CT.MaMon, F.DonGia, CT.SoLuong * F.TienLai as Lai from ChiTietHD CT, InfoFood F where CT.MaMon = F.MaMon) as TienLai";
            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null)
            {
                if (dt.Rows[0].IsNull(0))
                {
                    Profit = 0;
                }
                else
                {
                    Profit = Convert.ToInt32(dt.Rows[0][0]);
                }
            }
        }

        public void GetProfitByDate()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select SUM(TEMP.TienLai) from (select CT.MaMon, CT.SoLuong, CT.SoLuong*F.TienLai as TienLai, CONVERT(date, HD.ThoiGian, 101) AS NgayLap " +
                "from HoaDon HD, ChiTietHD CT, InfoFood F where HD.MaHD = CT.MaHD and F.MaMon = CT.MaMon) as TEMP " +
                "where TEMP.NgayLap >= @dateStart and TEMP.NgayLap <= @dateEnd";
            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = DateEnd;
            DataTable dt = db.ExecuteCommand(cmd);
            if (dt != null)
            {
                if (dt.Rows[0].IsNull(0))
                {
                    Profit = 0;
                }
                else 
                {
                    Profit = Convert.ToInt32(dt.Rows[0][0]);
                }             
            }
        }
    }
}
