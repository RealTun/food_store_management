using Form1.Bill.Model;
using Form1.Bill.Services;
using Form1.Employee.Services;
using QLNH.Voucher;

namespace Form1
{
    public partial class FormBill : Form
    {
        BillServices billServices { get; set; }
        BillModel billModel { get; set; }
        DiscountServices discountServices { get; set; }
        EmployeeService employeeService { get; set; }
        public FormBill()
        {
            InitializeComponent();
            billServices = new BillServices();
            billModel = new BillModel();
            discountServices = new DiscountServices();
            employeeService = new EmployeeService();
        }

        public FormBill(string? name, string? time, string? total, string? seller)
        {
            InitializeComponent();
            billServices = new BillServices();
            billModel = new BillModel();
            discountServices = new DiscountServices();
            employeeService = new EmployeeService();
            label_nameCustomer.Text = name;
            label_timeBill.Text = time;
            label_payment.Text = total;
            label_discount.Text = "0";
            lb_nguoiban.Text = seller;
        }

        public FormBill(string? name, string? time, string? total, string? discount, string? seller)
        {
            InitializeComponent();
            billServices = new BillServices();
            billModel = new BillModel();
            discountServices = new DiscountServices();
            employeeService = new EmployeeService();
            label_nameCustomer.Text = name;
            label_timeBill.Text = time;
            label_payment.Text = total;
            label_makm.Text = discount;
            label_discount.Text = discountServices.GetValueDiscount(label_makm.Text, DateTime.Now.ToString("yyyy/MM/dd")).ToString();
            lb_nguoiban.Text = seller;
        }


        private void FormBill_Load(object sender, EventArgs e)
        {
            billModel.AutoNumberBill();
            label_numberBill.Text = billModel.ID_order;
            if (label_numberBill.Text == "")
            {
                label_numberBill.Text = "1";
            }
        }

        public void AddItem(string nameFood, string amount, string price, string total)
        {
            string[] row = { amount, price, total };
            listview_Bill.Items.Add(nameFood).SubItems.AddRange(row);
        }

        private void bt_PrintBill_Click(object sender, EventArgs e)
        {
            TextBox txt_idemply = new TextBox();
            employeeService.GetIdEmployee(txt_idemply, lb_nguoiban.Text);

            if (label_discount.Text != "0")
            {
                billServices.AddBill(label_numberBill.Text, label_nameCustomer.Text, Convert.ToDouble(label_payment.Text), label_timeBill.Text, txt_idemply.Text);
                billServices.AddBillVoucher(label_numberBill.Text, label_makm.Text);

            }
            else
            {              
                billServices.AddBill(label_numberBill.Text, label_nameCustomer.Text, Convert.ToDouble(label_payment.Text), label_timeBill.Text, txt_idemply.Text);
            }

            foreach (ListViewItem item in listview_Bill.Items)
            {
                billServices.AddDetailsBill(item.Text, label_numberBill.Text, Convert.ToInt32(item.SubItems[1].Text));
            }

            billModel.AutoNumberBill();

            MessageBox.Show("Thanh toán thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
