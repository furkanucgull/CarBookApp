﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServicesCommands
{
	public class RemoveServicesCommand : IRequest
	{
        public int Id { get; set; }

		public RemoveServicesCommand(int id)
		{
			Id = id;
		}
	}
}
