namespace CarBook.Application.Features.Mediator.Results.ServicesResults
{
	public class GetServicesByIdQueryResult
	{
		public int ServiceID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string IconUrl { get; set; }
	}
}
