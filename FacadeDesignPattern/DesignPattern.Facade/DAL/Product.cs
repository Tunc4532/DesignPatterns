using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Facade.DAL
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string? ProductCatagory { get; set; }
        public List<OrderDetail>? orderDetails { get; set; }

    }
}
