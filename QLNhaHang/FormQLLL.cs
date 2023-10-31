using Form1.Employee.Services;
using QLNH;
using QLNH.Schedule;

namespace Form1
{
    public partial class FormQLLL : Form
    {
        EmployeeService employeeService { set; get; }
        ScheduleServices scheduleServices { set; get; }
        public FormQLLL()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            scheduleServices = new ScheduleServices();
        }

        private void FormQLLL_Load(object sender, EventArgs e)
        {
            employeeService.ShowNameEmployee(cb_TenNV);
            scheduleServices.ShowListSchedule(dgv_lichlam);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string Result = scheduleServices.CreateSchedule(txt_manv.Text, Convert.ToInt32(cb_calam.Text), dateWorkPick.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Thêm lịch làm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scheduleServices.ShowListSchedule(dgv_lichlam);
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string Result = scheduleServices.UpdateSchedule(txt_manv.Text, Convert.ToInt32(cb_calam.Text), dateWorkPick.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Sửa lịch làm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scheduleServices.ShowListSchedule(dgv_lichlam);
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Result = scheduleServices.DeleteSchedule(txt_manv.Text, dateWorkPick.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Xóa lịch làm thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scheduleServices.ShowListSchedule(dgv_lichlam);
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_lichlam_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_lichlam.CurrentCell.RowIndex;
            txt_manv.Text = dgv_lichlam.Rows[i].Cells[0].Value.ToString();
            cb_TenNV.Text = dgv_lichlam.Rows[i].Cells[1].Value.ToString();
            cb_calam.Text = dgv_lichlam.Rows[i].Cells[2].Value.ToString();
            dateWorkPick.Text = dgv_lichlam.Rows[i].Cells[3].Value.ToString();
        }

        private void cb_TenNV_SelectedValueChanged(object sender, EventArgs e)
        {
            employeeService.GetIdEmployee(txt_manv, cb_TenNV.Text);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            scheduleServices.ShowListScheduleByName(dgv_lichlam, cb_TenNV.Text);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            scheduleServices.ShowListSchedule(dgv_lichlam);
            cb_TenNV.Text = "";
            cb_calam.Text = "";
            txt_manv.Clear();
            dateWorkPick.ResetText();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            new XemLuong().Show();
        }
    }
}
