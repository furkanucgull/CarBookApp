using CarBook.Application.Features.Mediator.Commands.ServicesCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ServicesHandlers
{
	public class UpdateServicesCommandHandler : IRequestHandler<UpdateServicesCommand>
	{
		private readonly IRepository<Service> _repository;

		public UpdateServicesCommandHandler(IRepository<Service> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateServicesCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.ServiceID);
			values.Title = request.Title;
			values.Description = request.Description;
			values.IconUrl = request.IconUrl;
			await _repository.UpdateAsync(values);
		}
	}
}
