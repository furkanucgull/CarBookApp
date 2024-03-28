using CarBook.Application.Features.Mediator.Commands.ServicesCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ServicesHandlers
{
    public class RemoveServicesCommandHandler : IRequestHandler<RemoveServicesCommand>
    {
        private readonly IRepository<Service> _repository;

        public RemoveServicesCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveServicesCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
