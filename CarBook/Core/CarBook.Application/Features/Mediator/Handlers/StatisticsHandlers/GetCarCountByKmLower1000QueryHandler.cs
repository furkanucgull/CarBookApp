using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByKmLower1000QueryHandler : IRequestHandler<GetCarCountByKmLower1000Query, GetCarCountByKmLower1000QueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKmLower1000QueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmLower1000QueryResult> Handle(GetCarCountByKmLower1000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmLower1000();
            return new GetCarCountByKmLower1000QueryResult
            {
                CarCountByKmLower1000 = value,
            };

        }
    }
}
