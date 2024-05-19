using CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SocialMediaController : ControllerBase
	{
		private readonly IMediator _meditor;

		public SocialMediaController(IMediator meditor)
		{
			_meditor = meditor;
		}
		[HttpGet]
		public async Task<IActionResult> SocialMediaList()
		{
			var values = await _meditor.Send(new GetSocialMediaQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetSocialMedia(int id)
		{
			var value = await _meditor.Send(new GetSocialMediaByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand command)
		{
			await _meditor.Send(command);
			return Ok("SocialMedia Added Succesfully");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveSocialMedia(int id)
		{
			await _meditor.Send(new RemoveSocialMediaCommand(id));
			return Ok("SocialMedia Deleted Succesfully.");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command)
		{
			await _meditor.Send(command);
			return Ok("SocialMedia Updated Succesfully.");
		}
	}
}
