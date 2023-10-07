using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Facade.DAL
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CoustumerId { get; set; }
        public Coustemer? Coustemer { get; set; }
        public DateTime DateTime { get; set; }
        public List<OrderDetail>? orderDetails { get; set; }


    }
}
