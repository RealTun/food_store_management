using System.Data;
using System.Data.SqlClient;

namespace QLNH.Connect_DB
{
    public class Database
    {
        const string CON = "Server=LAPTOP-OJF6T1N2;Database=QLNhaHang;Trusted_Connection=True";

        public SqlCommand SqlCommandText
        {
            get
            {
                SqlCommand _SqlCommandText = new SqlCommand();
                SqlConnection sqlConnection = new SqlConnection(CON);
                _SqlCommandText.Connection = sqlConnection;
                _SqlCommandText.CommandType = CommandType.Text;
                
                return _SqlCommandText;
            }
        }

        public DataTable ExecuteCommand(SqlCommand SqlCommandText)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SqlCommandText);
            da.Fill(dt);
            return dt;
        }
    }
}
