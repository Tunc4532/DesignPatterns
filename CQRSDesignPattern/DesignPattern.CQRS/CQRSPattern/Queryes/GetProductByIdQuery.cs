namespace DesignPattern.CQRS.CQRSPattern.Queryes
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
