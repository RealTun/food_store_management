using Form1.Employee.Services;
using Form1.Payment.Services;
using QLNH.Voucher;
using System.Runtime.InteropServices;

namespace Form1
{
    public partial class Form_LapHoaDon : Form
    {
        PayService payService { get; set; }
        DiscountServices discountServices { get; set; }
        EmployeeService employeeServices { get; set; }
        public Form_LapHoaDon()
        {
            InitializeComponent();
            payService = new PayService();
            discountServices = new DiscountServices();
            employeeServices = new EmployeeService();
        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel_chucnang.Hide();
            employeeServices.ShowNameEmployee(cb_tennv);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txt_timeOrder.Text = dt.ToString();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool checkItem(string s)
        {
            foreach (ListViewItem item in listview_ThanhToan.Items)
            {
                if (s == item.Text)
                {
                    MessageBox.Show("Đã có trong hóa đơn!", "Vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        private void addItem(string food)
        {
            if (!checkItem(food))
            {
                payService.AddItemToListView(food, listview_ThanhToan);
                SetTotalBill();
            }
        }

        private int total;

        private void SetTotalBill()
        {
            total = 0;
            foreach (ListViewItem item in listview_ThanhToan.Items)
            {
                int temp = Convert.ToInt32(item.SubItems[3].Text);
                total += temp;
            }
            txt_totalProductPay.Text = total.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            addItem(btn.Text);
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            listview_ThanhToan.Items.Clear();
            txt_nameCus.Clear();
            txt_totalProductPay.Clear();
            txt_makm.Clear();
            txt_makm.ReadOnly = false;
            btn_apmakm.Enabled = true;
        }

        private void listview_ThanhToan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel_chucnang.Show();
            txt_nameProduct.Text = listview_ThanhToan.SelectedItems[0].SubItems[0].Text;
            txt_amount.Text = listview_ThanhToan.SelectedItems[0].SubItems[1].Text;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // khi cập nhật số lượng mới thì sẽ ra tổng tiền mới
            listview_ThanhToan.SelectedItems[0].SubItems[1].Text = txt_amount.Text;
            int price = Convert.ToInt32(listview_ThanhToan.SelectedItems[0].SubItems[2].Text);
            int amount = Convert.ToInt32(txt_amount.Text);
            int totalPrice = price * amount;
            listview_ThanhToan.SelectedItems[0].SubItems[3].Text = totalPrice.ToString();

            // tổng số tiền cần thanh toán
            SetTotalBill();
            panel_chucnang.Hide();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (listview_ThanhToan.Items.Count > 0)
            {
                listview_ThanhToan.Items.Remove(listview_ThanhToan.SelectedItems[0]);
                SetTotalBill();
            }
            else if (listview_ThanhToan.SelectedItems.Count < 1)
            {
                MessageBox.Show("Xóa lỗi", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private delegate void SetItemValueCallBack(string val1, string val2, string val3, string val4);
        private SetItemValueCallBack SetItemValue;

        private int signal = 0;
        private void btn_apmakm_Click(object sender, EventArgs e)
        {

            int discountValue = discountServices.GetValueDiscount(txt_makm.Text, DateTime.Now.ToString("yyyy/MM/dd"));
            if (discountValue > 0)
            {
                MessageBox.Show("Áp dụng thành công mã khuyến mại!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_totalProductPay.Text = (Convert.ToInt32(txt_totalProductPay.Text) - discountValue).ToString();
                signal = 1;
                txt_makm.ReadOnly = true;
                btn_apmakm.Enabled = false;
            }
            else
            {
                MessageBox.Show("Mã khuyến mại không tồn tại hoặc quá thời gian sử dụng!", "Vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_makm.Clear();
            }
        }

        private void bt_bill_Click(object sender, EventArgs e)
        {
            if (txt_nameCus.Text.Length < 1)
            {
                MessageBox.Show("Tên khách hàng không được trống!", "Vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (listview_ThanhToan.Items.Count < 1)
            {
                MessageBox.Show("Hóa đơn không được bỏ trống!", "Vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (signal == 1)
                {
                    FormBill frm = new FormBill(txt_nameCus.Text, txt_timeOrder.Text, txt_totalProductPay.Text, txt_makm.Text, cb_tennv.Text);
                    SetItemValue += new SetItemValueCallBack(frm.AddItem);
                    foreach (ListViewItem item in listview_ThanhToan.Items)
                    {
                        SetItemValue(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
                    }
                    frm.Show();
                }
                else
                {
                    FormBill frm = new FormBill(txt_nameCus.Text, txt_timeOrder.Text, txt_totalProductPay.Text, cb_tennv.Text);
                    SetItemValue += new SetItemValueCallBack(frm.AddItem);
                    foreach (ListViewItem item in listview_ThanhToan.Items)
                    {
                        SetItemValue(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
                    }
                    frm.Show();
                }
            }
        }
    }
}
