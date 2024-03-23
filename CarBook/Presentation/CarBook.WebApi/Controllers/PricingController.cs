using CarBook.Application.Features.Mediator.Commands.PricingCommands;
using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PricingController : ControllerBase
	{
		private readonly IMediator _meditor;

		public PricingController(IMediator meditor)
		{
			_meditor = meditor;
		}
		[HttpGet]
		public async Task<IActionResult> PricingList()
		{
			var values = await _meditor.Send(new GetPricingQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetPricing(int id)
		{
			var value = await _meditor.Send(new GetPricingByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
		{
			await _meditor.Send(command);
			return Ok("Pricing Added Succesfully");
		}
		[HttpDelete]
		public async Task<IActionResult> RemovePricing(int id)
		{
			await _meditor.Send(new RemovePricingCommand(id));
			return Ok("Pricing Deleted Succesfully.");
		}
		[HttpPut]
		public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
		{
			await _meditor.Send(command);
			return Ok("Pricing Updated Succesfully.");
		}
	}
}
