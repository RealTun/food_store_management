using QLNH.Table;

namespace QLNH
{
    public partial class QLBan : Form
    {
        TableServices tableServices { get; set; }
        public QLBan()
        {
            InitializeComponent();
            tableServices = new TableServices();
        }

        private void QLBan_Load(object sender, EventArgs e)
        {
            tableServices.ShowListTable(dgv_ban);
        }

        private void dgv_ban_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_ban.CurrentCell.RowIndex;
            txt_maban.Text = dgv_ban.Rows[i].Cells[0].Value.ToString();
            txt_tenban.Text = dgv_ban.Rows[i].Cells[1].Value.ToString();
            cb_loaiban.Text = dgv_ban.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maban.Text) || string.IsNullOrEmpty(txt_tenban.Text) || string.IsNullOrEmpty(cb_loaiban.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin bàn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Result = tableServices.CreateTable(txt_maban.Text, txt_tenban.Text, cb_loaiban.Text);
                if (string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Thêm thông tin bàn thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ResetControl();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maban.Text) || string.IsNullOrEmpty(txt_tenban.Text) || string.IsNullOrEmpty(cb_loaiban.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin bàn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Result = tableServices.UpdateTable(txt_maban.Text, txt_tenban.Text, cb_loaiban.Text);
                if (string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Sửa thông tin bàn thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ResetControl();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Result = tableServices.DeleteTable(txt_maban.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Xóa thông tin bàn thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetControl();
        }

        private void ResetControl()
        {
            txt_maban.Clear();
            txt_tenban.Clear();
            cb_loaiban.Text = "";
            tableServices.ShowListTable(dgv_ban);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void btn_datban_Click(object sender, EventArgs e)
        {
            new DatBan().Show();
        }
    }
}
