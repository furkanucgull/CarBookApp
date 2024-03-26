using CarBook.Application.Features.Mediator.Results.TestimonialResult;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
