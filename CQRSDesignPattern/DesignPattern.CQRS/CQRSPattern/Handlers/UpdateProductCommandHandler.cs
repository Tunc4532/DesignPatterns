using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.ProductID = command.ProductID;
            values.Status = true;
            values.Description = command.Description;
            values.Price = command.Price;
            values.Stock = command.Stock;
            _context.SaveChanges();
        }
    }
}
