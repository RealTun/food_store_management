using Form1.Employee.Services;
using System.Globalization;

namespace Form1
{
    public partial class FormQLNV : Form
    {
        private EmployeeService employeeService { get; set; }
        public FormQLNV()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListNV_Load(object sender, EventArgs e)
        {
            employeeService.ShowListEmployee(dgv_NV);
        }

        private bool CheckNull()
        {
            if (string.IsNullOrEmpty(txt_HoTen.Text) || string.IsNullOrEmpty(txt_MaNV.Text) || string.IsNullOrEmpty(txt_numberphone.Text) || string.IsNullOrEmpty(txt_chucvu.Text) || string.IsNullOrEmpty(txt_luong.Text) || string.IsNullOrEmpty(txt_chucvu.Text))
            {
                return false;
            }
            return true;
        }

        private void button_addNV_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                string Result = employeeService.CreateEmployee(txt_MaNV.Text, txt_HoTen.Text, cb_GioiTinh.Text, date_NV.Text, txt_numberphone.Text, txt_chucvu.Text, Convert.ToInt32(txt_luong.Text));
                if (string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            employeeService.ShowListEmployee(dgv_NV);
            ResetControl();
        }

        private void button_updateInfoNV_Click(object sender, EventArgs e)
        {
            int i = dgv_NV.CurrentCell.RowIndex;
            var id_empl = dgv_NV.Rows[i].Cells[0].Value.ToString();
            var name_empl = txt_HoTen.Text;
            var sex_empl = cb_GioiTinh.Text;
            var birth_empl = date_NV.Text;
            var phone_empl = txt_numberphone.Text;
            var role_empl = txt_chucvu.Text;
            var salary_empl = Convert.ToInt32(txt_luong.Text);

            string Result = employeeService.UpdateEmployee(id_empl, name_empl, sex_empl, birth_empl, phone_empl, role_empl, salary_empl);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            employeeService.ShowListEmployee(dgv_NV);
            ResetControl();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int i = dgv_NV.CurrentCell.RowIndex;
            var id_empl = dgv_NV.Rows[i].Cells[0].Value.ToString();
            string Result = employeeService.DeleteEmployee(id_empl);
            MessageBox.Show($"id : {dgv_NV.Rows[i].Cells[0].Value}");
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Xóa thông tin thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            employeeService.ShowListEmployee(dgv_NV);
            ResetControl();
        }

        private void ResetControl()
        {
            txt_MaNV.Clear();
            date_NV.ResetText();
            txt_HoTen.Clear();
            cb_GioiTinh.Text = "";
            txt_numberphone.Clear();
            txt_chucvu.Clear();
            txt_luong.Clear();
            txt_MaNV.Focus();
        }

        private void Clear_InfoNV_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void dgv_NV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_NV.CurrentRow.Index;
            txt_MaNV.Text = dgv_NV.Rows[i].Cells[0].Value.ToString();
            txt_HoTen.Text = dgv_NV.Rows[i].Cells[1].Value.ToString();
            cb_GioiTinh.Text = dgv_NV.Rows[i].Cells[2].Value.ToString();
            date_NV.Text = dgv_NV.Rows[i].Cells[3].Value.ToString();
            txt_numberphone.Text = dgv_NV.Rows[i].Cells[4].Value.ToString();
            txt_chucvu.Text = dgv_NV.Rows[i].Cells[5].Value.ToString();
            txt_luong.Text = dgv_NV.Rows[i].Cells[6].Value.ToString();
        }
    }
}
