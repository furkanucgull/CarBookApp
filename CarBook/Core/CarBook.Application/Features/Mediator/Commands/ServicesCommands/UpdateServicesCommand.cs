using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServicesCommands
{
	public class UpdateServicesCommand :IRequest
	{
		public int ServiceID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string IconUrl { get; set; }
	}
}
