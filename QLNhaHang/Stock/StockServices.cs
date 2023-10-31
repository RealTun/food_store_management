using System.Data;
using System.Data.SqlClient;

namespace QLNH.Stock
{
    public class StockServices
    {
        public void ShowListStock(DataGridView dgv)
        {
            StockModel stock = new StockModel();
            stock.ShowListStock(dgv);
        }

        public void ShowListStockByDate(DataGridView dgv, string? date)
        {
            StockModel stock = new StockModel();
            stock.ShowListStockByDate(dgv, date);
        }

        public string CreateStock(string? manl, string? tennl, int dg, int sl, string? hsd)
        {
            StockModel stock = new StockModel(manl, tennl, dg, sl, hsd);
            return stock.CreateStock();
        }

        public string UpdateStock(string? manl, string? tennl, int dg, int sl, string? hsd)
        {
            StockModel stock = new StockModel(manl, tennl, dg, sl, hsd);
            return stock.UpdateStock();
        }

        public string DeleteStock(string? manl)
        {
            StockModel stock = new StockModel(manl);
            return stock.DeleteStock();
        }
    }
}
