namespace DesignCompositePattern.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public Catagory? Catagory { get; set; }
        public int CatagoryID { get; set; }

    }
}
