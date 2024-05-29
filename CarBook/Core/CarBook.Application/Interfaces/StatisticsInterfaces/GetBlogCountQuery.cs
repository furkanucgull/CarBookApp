using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using MediatR;

namespace CarBook.Application.Interfaces.StatisticsInterfaces
{
    public class GetBlogCountQuery : IRequest<GetBlogCountQueryResult>
    {
    }
}
