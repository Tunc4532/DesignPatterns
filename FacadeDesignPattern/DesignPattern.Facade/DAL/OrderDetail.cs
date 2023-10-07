using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Facade.DAL
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CoustumerId { get; set; }
        public Coustemer? Coustemer { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductTotalPrice { get; set; }



    }
}
