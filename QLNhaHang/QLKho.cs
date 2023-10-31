using DevExpress.Charts.Model;
using QLNH.Stock;

namespace Form1
{
    public partial class QLKho : Form
    {
        StockServices stockServices { get; set; }
        public QLKho()
        {
            InitializeComponent();
            stockServices = new StockServices();
        }

        private void QLKho_Load(object sender, EventArgs e)
        {
            stockServices.ShowListStock(dgv_stock);
            dgv_stock.Sort(dgv_stock.Columns[4], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void dgv_stock_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_stock.CurrentCell.RowIndex;
            txt_maNL.Text = dgv_stock.Rows[i].Cells[0].Value.ToString();
            txt_tenNL.Text = dgv_stock.Rows[i].Cells[1].Value.ToString();
            txt_donGia.Text = dgv_stock.Rows[i].Cells[2].Value.ToString();
            txt_soluong.Text = dgv_stock.Rows[i].Cells[3].Value.ToString();
            datePickHSD.Text = dgv_stock.Rows[i].Cells[4].Value.ToString();
        }

        private bool CheckNull()
        {
            if (string.IsNullOrEmpty(txt_maNL.Text) || string.IsNullOrEmpty(txt_tenNL.Text) || string.IsNullOrEmpty(txt_donGia.Text) || string.IsNullOrEmpty(txt_soluong.Text))
            {
                return true;
            }
            return false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!CheckNull())
            {
                string Result = stockServices.CreateStock(txt_maNL.Text, txt_tenNL.Text, Convert.ToInt32(txt_donGia.Text), Convert.ToInt32(txt_soluong.Text), datePickHSD.Text);
                if (string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Thêm thông tin nguyên liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetControl();

                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nguyên liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!CheckNull())
            {
                string Result = stockServices.UpdateStock(txt_maNL.Text, txt_tenNL.Text, Convert.ToInt32(txt_donGia.Text), Convert.ToInt32(txt_soluong.Text), datePickHSD.Text);
                if (string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Sửa thông tin nguyên liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetControl();

                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nguyên liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Result = stockServices.DeleteStock(txt_maNL.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Xóa thông tin nguyên liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControl();

            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetControl()
        {
            txt_maNL.Clear();
            txt_tenNL.Clear();
            txt_donGia.Clear();
            txt_soluong.Clear();
            datePickHSD.ResetText();
            stockServices.ShowListStock(dgv_stock);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            stockServices.ShowListStockByDate(dgv_stock, dateSearch.Value.Date.ToString());
        }

    }
}
