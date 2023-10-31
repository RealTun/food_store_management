using System;

namespace QLNH.Voucher
{
    public class DiscountServices
    {
        public void ShowListDiscount(DataGridView dgv)
        {
            Discount discount = new Discount();
            discount.ShowListDiscount(dgv);
        }

        public string AddDiscount(string? maKM, string? tenKM, int gt, string? thgianBD, string? thgianKT)
        {
            Discount discount = new Discount(maKM, tenKM, gt, thgianBD, thgianKT);
            return discount.AddDiscount();
        }

        public string UpdateDiscount(string? maKM, string? tenKM, int gt, string? thgianBD, string? thgianKT)
        {
            Discount discount = new Discount(maKM, tenKM, gt, thgianBD, thgianKT);
            return discount.UpdateDiscount();
        }

        public string DeleteDiscount(string? maKM)
        {
            Discount discount = new Discount(maKM);
            return discount.DeleteDiscount();
        }

        public int GetValueDiscount(string? maKM, string? today)
        {
            Discount discount = new Discount(maKM, today);
            return discount.GetValueDiscount();
        }
    }
}
