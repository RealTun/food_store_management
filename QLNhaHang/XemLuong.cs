using QLNH.Schedule;

namespace QLNH
{
    public partial class XemLuong : Form
    {
        ScheduleServices scheduleServices { get; set; }
        public XemLuong()
        {
            InitializeComponent();
            scheduleServices = new ScheduleServices();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_month.Text) || string.IsNullOrEmpty(cb_year.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ tháng và năm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                scheduleServices.ShowSalary(dgv_salary, Convert.ToInt32(cb_month.Text), Convert.ToInt32(cb_year.Text));
            }
        }
    }
}
