using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByTransmissionisAutoQueryHandler : IRequestHandler<GetCarCountByTransmissionisAutoQuery, GetCarCountByTransmissionisAutoQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByTransmissionisAutoQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByTransmissionisAutoQueryResult> Handle(GetCarCountByTransmissionisAutoQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByTransmissionisAuto();
            return new GetCarCountByTransmissionisAutoQueryResult
            {
                CarCountByTransmissionisAuto = value,
            };
            {
            }
        }
    }
}
