using Form1.Bill.Model;

namespace Form1.Bill.Services
{
    public class BillServices
    {
        public BillServices() { }
        public void AddBill(string id, string namecus, double total, string timeorder, string id_empl)
        {
            BillModel bill = new BillModel(id, namecus, total, timeorder, id_empl);
            bill.AddBill();
        }

        public void AddBillVoucher(string id, string voucher)
        {
            BillModel bill = new BillModel(id, voucher);
            bill.AddBillVoucher();
        }

        public void AddDetailsBill(string name, string id_or, int amount)
        {
            BillDetails details = new BillDetails(id_or, amount);
            details.GetID_Food(name);
            details.AddDetailsBill();
        }

        public void DeleteBill(string? mahd)
        {
            BillModel bill = new BillModel();
            bill.DeleteDetailsBill(mahd);
            bill.DeleteBillVoucher(mahd);
            bill.DeleteBill(mahd);
        }
        public bool IsExistedBill(string id_order)
        {
            BillInfo info = new BillInfo();
            return info.IsExistedBill(id_order);
        }

        public void ShowDetailsBill(string? id_order, DataGridView dgv)
        {
            BillInfo bill = new BillInfo();
            bill.GetInfoBill(id_order);
            bill.ShowDetailsBill(id_order, dgv);
        }

        public void ShowListBills(DataGridView dgv)
        {
            BillInfo bill = new BillInfo();
            bill.ShowListBills(dgv);
        }
    }
}
