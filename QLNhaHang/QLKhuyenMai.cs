using QLNH.Voucher;

namespace QLNH
{
    public partial class QLKhuyenMai : Form
    {
        DiscountServices discountServices { get; set; }
        public QLKhuyenMai()
        {
            InitializeComponent();
            discountServices = new DiscountServices();
        }

        private void QLKhuyenMai_Load(object sender, EventArgs e)
        {
            discountServices.ShowListDiscount(dgv_discount);
        }

        private void dgvFood_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_discount.CurrentCell.RowIndex;
            txt_makm.Text = dgv_discount.Rows[i].Cells[0].Value.ToString();
            txt_tenkm.Text = dgv_discount.Rows[i].Cells[1].Value.ToString();
            txt_giatri.Text = dgv_discount.Rows[i].Cells[2].Value.ToString();
            dateStart.Text = dgv_discount.Rows[i].Cells[3].Value.ToString();
            dateEnd.Text = dgv_discount.Rows[i].Cells[4].Value.ToString();

        }

        private bool CheckNullInput()
        {
            if (string.IsNullOrEmpty(txt_makm.Text) || string.IsNullOrEmpty(txt_tenkm.Text) || string.IsNullOrEmpty(txt_giatri.Text))
            {
                return false;
            }
            return true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(CheckNullInput())
            {
                string Result = discountServices.AddDiscount(txt_makm.Text, txt_tenkm.Text, Convert.ToInt32(txt_giatri.Text), dateStart.Text, dateEnd.Text);
                if(string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Thêm mã khuyến mại thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    discountServices.ShowListDiscount(dgv_discount);
                    ResetControl();
                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("Thông tin nhập không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string Result = discountServices.UpdateDiscount(txt_makm.Text, txt_tenkm.Text, Convert.ToInt32(txt_giatri.Text), dateStart.Text, dateEnd.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Sửa thông tin mã khuyến mại thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                discountServices.ShowListDiscount(dgv_discount);
                ResetControl();
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Result = discountServices.DeleteDiscount(txt_makm.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Xóa mã khuyến mại thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                discountServices.ShowListDiscount(dgv_discount);
                ResetControl();
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetControl()
        {
            txt_makm.Clear();
            txt_tenkm.Clear();
            txt_giatri.Clear();
            dateStart.ResetText();
            dateEnd.ResetText();
            txt_makm.Focus();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}
