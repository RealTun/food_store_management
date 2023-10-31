using Form1.Bill.Model;
using Form1.Bill.Services;

namespace Form1
{
    public partial class DetailsBill : Form
    {
        BillServices billServices { get; set; }
        BillInfo bill { get; set; }
        public string? Id_Order { get; set; }
        public DetailsBill(string? id)
        {
            InitializeComponent();
            billServices = new BillServices();
            bill = new BillInfo();
            Id_Order = id;
        }

        private void SetInfo()
        {
            lb_numBill.Text = bill.ID_order;
            lb_nameCus.Text = bill.NameCus;
            lb_time.Text = bill.TimeOrder;
            lb_makm.Text = bill.Voucher;
            lb_nguoiban.Text = bill.NameEmpl;
            lb_tongtien.Text = bill.Total;
        }

        private void DetailsBill_Load(object sender, EventArgs e)
        {
            bill.GetInfoBill(Id_Order);
            SetInfo();
            billServices.ShowDetailsBill(Id_Order, dgv_billDetails);
        }

        private void btn_hoantra_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thực sự muốn hoàn trả hóa đơn này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                billServices.DeleteBill(Id_Order);
                MessageBox.Show("Thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }    
        }
    }
}
