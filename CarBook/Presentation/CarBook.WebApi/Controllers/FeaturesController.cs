using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Queries.FeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeaturesController : ControllerBase
	{
		private readonly IMediator _meditor;

		public FeaturesController(IMediator meditor)
		{
			_meditor = meditor;
		}
		[HttpGet]
		public async Task<IActionResult> FeatureList()
		{
			var values = await _meditor.Send(new GetFeatureQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetFeature(int id)
		{
			var value = await _meditor.Send(new GetFeatureByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateFeature(CreateFeatureCommand command)
		{
			await _meditor.Send(command);
			return Ok("Feature Added Succesfully");
		}
		[HttpDelete]
		public async Task<IActionResult> RemoveFeature(int id)
		{
			await _meditor.Send(new RemoveFeatureCommand(id));
			return Ok("Feature Deleted Succesfully.");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand command)
		{
			await _meditor.Send(command);
			return Ok("Feature Updated Succesfully.");
		}
	}
}
