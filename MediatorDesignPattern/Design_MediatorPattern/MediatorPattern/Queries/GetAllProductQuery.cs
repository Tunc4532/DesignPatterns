using Design_MediatorPattern.MediatorPattern.Results;
using MediatR;

namespace Design_MediatorPattern.MediatorPattern.Queries
{
    public class GetAllProductQuery : IRequest<List<GetAllProductQueryResult>>
    {

    }
}
