namespace Design_MediatorPattern.DAL
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int ProductStock { get; set; }
        public string? ProductStockType { get; set; }
        public decimal ProductPrice { get; set; }
        public string? ProductCatagory { get; set; }
    }
}
