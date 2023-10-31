using QLNH.Connect_DB;
using System.Data;
using System.Data.SqlClient;

namespace Form1.Connect_DB.Model
{
    public class Account
    {
        Database db = new Database();
        public string? usn { get; set; }
        public string? pwd { get; set; }
     //   public string? pms { get; set; }

        public Account(string un)
        {
            usn = un;
        }
        public Account(string un, string pw)
        {
            usn = un;
            pwd = pw;            
        }


        public bool IsExisted()
        {
            try
            {
                var cmd = db.SqlCommandText;

                cmd.CommandText = "select count(*) from TAIKHOAN where [usn] = @usn and [pwd] = @pwd";
                cmd.Parameters.Add("usn", SqlDbType.VarChar).Value = usn;
                cmd.Parameters.Add("pwd", SqlDbType.VarChar).Value = pwd;

                DataTable dt = db.ExecuteCommand(cmd);
                if (dt != null && dt.Rows.Count == 1)
                {
                    if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 0)
                    {
                        return false;
                    }
                }
            }
            catch
            {

            }

            return true;
        }

        public bool Decentralization()
        {
            var cmd = db.SqlCommandText;
            cmd.CommandText = "select count(*) from TK_NV inner join NHANVIEN NV on TK_NV.MaNV = NV.MaNV " +
                            "where NV.ChucVu = N'Quản lý' and TK_NV.usn = @usn";
            cmd.Parameters.Add("usn", SqlDbType.VarChar).Value = usn;

            DataTable dt = db.ExecuteCommand(cmd);
            if(dt != null)
            {
                if (dt.Rows[0][0].ToString() == "0")
                {
                    return false;
                }
            }

            return true;
        }
    }
}
