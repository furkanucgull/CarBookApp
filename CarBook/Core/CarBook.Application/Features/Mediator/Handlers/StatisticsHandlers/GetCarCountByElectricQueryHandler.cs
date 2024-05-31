using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByElectricQueryHandler : IRequestHandler<GetCarCountByElectricQuery, GetCarCountByElectricQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByElectricQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByElectricQueryResult> Handle(GetCarCountByElectricQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByElectric();
            return new GetCarCountByElectricQueryResult
            {
                CarCountByElectric = value,
            };

        }
    }
}
