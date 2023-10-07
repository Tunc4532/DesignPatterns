namespace DesignPattern.CQRS.CQRSPattern.Queryes
{
    public class GetProductUpdateByIdQuery
    {
        public GetProductUpdateByIdQuery(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
