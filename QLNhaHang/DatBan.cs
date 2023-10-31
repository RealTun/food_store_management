using DevExpress.XtraRichEdit.Import.Html;
using Form1.Employee.Services;
using QLNH.Table;

namespace QLNH
{
    public partial class DatBan : Form
    {
        EmployeeService employeeService { get; set; }
        TableServices tableServices { get; set; }
        public DatBan()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            tableServices = new TableServices();
        }

        private void DatBan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tableServices.GetIdTable(txt_maban, btn.Text);
        }

        private void DatBan_Load(object sender, EventArgs e)
        {
            employeeService.ShowNameEmployee(cb_tennv);
            tableServices.ListOrderTable(dgv_datban);
            DateTime dateTime = DateTime.Now;
            txt_thoigian.Text = dateTime.ToString();
        }

        private void cb_tennv_SelectedValueChanged(object sender, EventArgs e)
        {
            employeeService.GetIdEmployee(txt_manv, cb_tennv.Text);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_tennv.Text) || string.IsNullOrEmpty(txt_tenkh.Text) || string.IsNullOrEmpty(txt_sdt.Text) || string.IsNullOrEmpty(txt_maban.Text))
            {
                MessageBox.Show("Vui lòng điền điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Result = tableServices.CreateOrderTable(txt_maban.Text, txt_manv.Text, txt_tenkh.Text, txt_sdt.Text, txt_thoigian.Text);
                if (string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Đặt bàn thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetControl();
                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetControl()
        {
            txt_maban.Clear();
            txt_sdt.Clear();
            txt_tenkh.Clear();
            txt_manv.Clear();
            cb_tennv.Text = "";
            tableServices.ListOrderTable(dgv_datban);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            tableServices.ListOrderTableByDate(dgv_datban, datePick.Value.Day, datePick.Value.Month, datePick.Value.Year);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Result = tableServices.DeleteOrderTable(txt_maban.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Xóa thông tin đặt bàn thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControl();
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_datban_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_datban.CurrentCell.RowIndex;
            txt_maban.Text = dgv_datban.Rows[i].Cells[0].Value.ToString();
            txt_tenkh.Text = dgv_datban.Rows[i].Cells[2].Value.ToString();
            txt_sdt.Text = dgv_datban.Rows[i].Cells[3].Value.ToString();
            txt_thoigian.Text = dgv_datban.Rows[i].Cells[4].Value.ToString();
        }
    }
}
