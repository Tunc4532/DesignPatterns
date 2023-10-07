using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Facade.DAL
{
    public class Coustemer
    {
        [Key]
        public int CoustumerId { get; set; }
        public string? CoustumerName  { get; set; }
        public string? CoustumerSurname  { get; set; }
        public string? CoustumerAdress  { get; set; }
        public string? CoustumerCity  { get; set; }
        public List<Order>? Orders { get; set; }
        public List<OrderDetail>? orderDetails { get; set; }
    }
}
