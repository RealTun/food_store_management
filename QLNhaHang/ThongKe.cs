using LiveCharts;
using LiveCharts.Wpf;
using QLNH.Statistical;

namespace Form1
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void AddChart()
        {
            LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart();
            pieChart.Width = 350;
            pieChart.Height = 350;
            Random rd = new Random();
            SeriesCollection sers = new SeriesCollection();
            for (int i = 0; i < 5; i++)
            {
                PieSeries ser = new PieSeries();
                ser.Values = new ChartValues<double> { Math.Round(rd.NextDouble(), 2) };
                ser.Title = "ID" + (i + 1).ToString();
                ser.DataLabels = true;
                sers.Add(ser);
            }

            pieChart.Series = sers;
            panel1.Controls.Add(pieChart);
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            AddChart();
            SetValue();
        }

        private void SetValue()
        {
            Statistis stt = new Statistis();
            stt.GetTotalBill();
            stt.GetTotalCustomer();
            stt.GetRevenue();
            stt.GetProfit();
            stt.GetTop5(lb_topOder);
            lb_totalBill.Text = stt.TotalBill.ToString();
            lb_totalCus.Text = stt.TotalCustomer.ToString();
            lb_Revenue.Text = stt.Revenue.ToString();
            lb_profit.Text = stt.Profit.ToString();
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            Statistis stt = new Statistis(datePickStart.Value.ToString(), datePickEnd.Value.ToString());
            stt.GetRevenueByDate();
            stt.GetTotalCustomerByDate();
            lb_topOder.Text = "";
            stt.GetTotalBillByDate();
            stt.GetProfitByDate();
            stt.GetTop5ByDate(lb_topOder);
            lb_Revenue.Text = stt.Revenue.ToString();
            lb_totalCus.Text = stt.TotalCustomer.ToString();
            lb_totalBill.Text = stt.TotalBill.ToString();
            lb_profit.Text = stt.Profit.ToString();
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            lb_topOder.Text = "";
            SetValue();
        }
    }
}
