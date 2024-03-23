using CarBook.Application.Features.Mediator.Queries.ServicesQueries;
using CarBook.Application.Features.Mediator.Results.ServicesResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ServicesHandlers
{
	public class GetServicesByIdQueryHandler : IRequestHandler<GetServicesByIdQuery, GetServicesByIdQueryResult>
	{
		private readonly IRepository<Service> _repository;

		public GetServicesByIdQueryHandler(IRepository<Service> repository)
		{
			_repository = repository;
		}

		public async Task<GetServicesByIdQueryResult> Handle(GetServicesByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetServicesByIdQueryResult
			{
				Description = values.Description,
				IconUrl = values.IconUrl,
				ServiceID = values.ServiceID,
				Title = values.Title,
			};
		}
	}
}
