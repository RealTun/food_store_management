using System.Data.SqlClient;
using System.Data;
using QLNH.Connect_DB;

namespace Form1.Payment.Model
{
    public class Pay
    {
        Database db = new Database();
        public string? NameProduct { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }

        public void AddItemToListView(ListView listview_payment)
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select * from InfoFood where [TenMon] = @nameProduct";
            cmd.Parameters.Add("nameProduct", SqlDbType.NVarChar).Value = NameProduct;

            DataTable dt = db.ExecuteCommand(cmd);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[1].ToString());
                item.SubItems.Add("1");
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[2].ToString());
                listview_payment.Items.Add(item);
            }
        }

    }
}
