using CarBook.Application.Features.Mediator.Results.ServicesResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.ServicesQueries
{
	public class GetServicesByIdQuery:IRequest<GetServicesByIdQueryResult>
	{
        public int Id { get; set; }

		public GetServicesByIdQuery(int id)
		{
			Id = id;
		}
	}
}
