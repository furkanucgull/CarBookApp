using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LocationController : ControllerBase
	{
		private readonly IMediator _meditor;

		public LocationController(IMediator meditor)
		{
			_meditor = meditor;
		}
		[HttpGet]
		public async Task<IActionResult> LocationList()
		{
			var values = await _meditor.Send(new GetLocationQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetLocation(int id)
		{
			var value = await _meditor.Send(new GetLocationByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateLocation(CreateLocationCommand command)
		{
			await _meditor.Send(command);
			return Ok("Location Added Succesfully");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveLocation(int id)
		{
			await _meditor.Send(new RemoveLocationCommand(id));
			return Ok("Location Deleted Succesfully.");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command)
		{
			await _meditor.Send(command);
			return Ok("Location Updated Succesfully.");
		}
	}
}
