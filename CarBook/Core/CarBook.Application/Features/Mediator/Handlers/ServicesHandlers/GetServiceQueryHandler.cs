using CarBook.Application.Features.Mediator.Queries.ServicesQueries;
using CarBook.Application.Features.Mediator.Results.ServicesResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ServicesHandlers
{
	public class GetServiceQueryHandler : IRequestHandler<GetServicesQuery, List<GetServicesQueryResult>>
	{
		private readonly IRepository<Service> _repository;

		public GetServiceQueryHandler(IRepository<Service> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetServicesQueryResult>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetServicesQueryResult
			{
				Title = x.Title,
				ServiceID = x.ServiceID,
				Description = x.Description,
				IconUrl = x.IconUrl,
			}).ToList();
		}
	}
}
