using CarBook.Application.Features.Mediator.Commands.ServicesCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ServicesHandlers
{
	public class CreateServicesCommandHandler : IRequestHandler<CreateServicesCommand>
	{
		private readonly IRepository<Service> _repository;
		public CreateServicesCommandHandler(IRepository<Service> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateServicesCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Service
			{
				Description = request.Description,
				IconUrl = request.IconUrl,
				Title = request.Title,
			});

		}
	}
}
