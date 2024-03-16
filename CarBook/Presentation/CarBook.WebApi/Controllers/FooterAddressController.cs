using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FooterAddressController : ControllerBase
	{
		private readonly IMediator _meditor;

		public FooterAddressController(IMediator meditor)
		{
			_meditor = meditor;
		}

		[HttpGet]
		public async Task<IActionResult> FooterAddressList()
		{
			var values = await _meditor.Send(new GetFooterAddressQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetFooterAddress(int id)
		{
			var value = await _meditor.Send(new GetFooterAddressByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command)
		{
			await _meditor.Send(command);
			return Ok("FooterAddress Added Succesfully");
		}
		[HttpDelete]
		public async Task<IActionResult> RemoveFooterAddress(int id)
		{
			await _meditor.Send(new RemoveFooterAddressCommand(id));
			return Ok("FooterAddress Deleted Succesfully.");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command)
		{
			await _meditor.Send(command);
			return Ok("FooterAddress Updated Succesfully.");
		}
	}
}

