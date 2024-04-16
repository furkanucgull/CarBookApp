using CarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public TagCloudsController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            var values = await _meditor.Send(new GetTagCloudQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloud(int id)
        {
            var value = await _meditor.Send(new GetTagCloudByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
        {
            await _meditor.Send(command);
            return Ok("TagCloud Added Succesfully");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTagCloud(int id)
        {
            await _meditor.Send(new RemoveTagCloudCommand(id));
            return Ok("TagCloud Deleted Succesfully.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await _meditor.Send(command);
            return Ok("TagCloud Updated Succesfully.");
        }
    }
}
