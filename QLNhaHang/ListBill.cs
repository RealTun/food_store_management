﻿using Form1.Bill.Services;
using System.Data;
using System.Data.SqlClient;

namespace Form1
{
    public partial class ListBill : Form
    {
        BillServices billServices { get; set; }
        public ListBill()
        {
            InitializeComponent();
            billServices = new BillServices();
        }

        private void txt_search_DoubleClick(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        private void QuanLyHD_Load(object sender, EventArgs e)
        {
            BillServices billServices = new BillServices();
            billServices.ShowListBills(dgv_HD);
            dgv_HD.Sort(dgv_HD.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool Result = billServices.IsExistedBill(txt_search.Text);
            if (Result)
            {
                MessageBox.Show("Có hóa đơn này!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DetailsBill details = new DetailsBill(txt_search.Text);
                details.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn này!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_HD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_HD.CurrentCell.RowIndex;
            DetailsBill details = new DetailsBill(dgv_HD.Rows[i].Cells[0].Value.ToString());
            details.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            billServices.ShowListBills(dgv_HD);
            txt_search.Clear();
        }
    }
}
