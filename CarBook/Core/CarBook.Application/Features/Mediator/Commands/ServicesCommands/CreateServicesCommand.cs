using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServicesCommands
{
	public class CreateServicesCommand : IRequest
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string IconUrl { get; set; }
	}
}
