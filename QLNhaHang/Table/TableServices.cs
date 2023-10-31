namespace QLNH.Table
{
    public class TableServices
    {
        public void ShowListTable(DataGridView dgv)
        {
            TableModel table = new TableModel();
            table.ShowListTable(dgv);
        }

        public void ListOrderTable(DataGridView dgv)
        {
            TableModel table = new TableModel();
            table.ListOrderTable(dgv);
        }

        public void ListOrderTableByDate(DataGridView dgv, int day, int month, int year)
        {
            TableModel table = new TableModel();
            table.ListOrderTableByDate(dgv, day, month, year);
        }

        public void GetIdTable(TextBox txt, string? name)
        {
            TableModel table = new TableModel();
            table.GetIdTable(txt, name);
        }

        public string CreateOrderTable(string? mb, string? manv, string? kh, string? sdt, string? tg)
        {
            TableModel table = new TableModel();
            return table.CreateOrderTable(mb, manv, kh, sdt, tg);
        }

        public string CreateTable(string? mb, string? tb, string? lb)
        {
            TableModel table = new TableModel(mb, tb, lb);
            return table.CreateTable();
        }

        public string UpdateTable(string? mb, string? tb, string? lb)
        {
            TableModel table = new TableModel(mb, tb, lb);
            return table.UpdateTable();
        }

        public string DeleteTable(string? mb)
        {
            TableModel table = new TableModel(mb);
            return table.DeleteTable();
        }

        public string DeleteOrderTable(string? mb)
        {
            TableModel table = new TableModel();
            return table.DeleteOrderTable(mb);
        }
    }
}
