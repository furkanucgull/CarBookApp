using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
	public class CreateCarCommandHandler
	{
		private readonly IRepository<Car> _repository;

		public CreateCarCommandHandler(IRepository<Car> repository)
		{
			_repository = repository;
		}
		public async Task Handle(CreateCarCommand command)
		{
			await _repository.CreateAsync(new Car
			{
				Fuel = command.Fuel,
				CoverImageUrl = command.CoverImageUrl,
				Transmission = command.Transmission,
				Seat = command.Seat,
				Model = command.Model,
				Luggage = command.Luggage,
				Km = command.Km,
				BigImageUrl = command.BigImageUrl,
				BrandID = command.BrandID,

			});
		}
	}
}
