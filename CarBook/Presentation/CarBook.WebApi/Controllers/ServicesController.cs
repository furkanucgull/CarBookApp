using CarBook.Application.Features.Mediator.Commands.ServicesCommands;
using CarBook.Application.Features.Mediator.Queries.ServicesQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		private readonly IMediator _meditor;

		public ServicesController(IMediator meditor)
		{
			_meditor = meditor;
		}
		[HttpGet]
		public async Task<IActionResult> ServicesList()
		{
			var values = await _meditor.Send(new GetServicesQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetServices(int id)
		{
			var value = await _meditor.Send(new GetServicesByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateServices(CreateServicesCommand command)
		{
			await _meditor.Send(command);
			return Ok("Services Added Succesfully");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveServices(int id)
		{
			await _meditor.Send(new RemoveServicesCommand(id));
			return Ok("Services Deleted Succesfully.");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateServices(UpdateServicesCommand command)
		{
			await _meditor.Send(command);
			return Ok("Services Updated Succesfully.");
		}
	}
}
