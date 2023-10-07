namespace DessignPattern.ObServer.DAL
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public int DiscountAmount { get; set; }
        public string DiscountCode { get; set; }
        public bool DiscountCodeStatus { get; set; }
    }
}
