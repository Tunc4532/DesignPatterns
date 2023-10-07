namespace DesignCompositePattern.DAL
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        public string? CatagoryName { get; set; }
        public int UpperCatagoryID { get; set; }
        public List<Product>? Products { get; set; }

    }
}
