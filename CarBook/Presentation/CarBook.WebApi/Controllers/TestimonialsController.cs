using CarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Application.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public TestimonialsController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var values = await _meditor.Send(new GetTestimonialQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _meditor.Send(new GetTestimonialByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await _meditor.Send(command);
            return Ok("Testimonial Added Succesfully");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveTestimonial(int id)
        {
            await _meditor.Send(new RemoveTestimonialCommand(id));
            return Ok("Testimonial Deleted Succesfully.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await _meditor.Send(command);
            return Ok("Testimonial Updated Succesfully.");
        }
    }
}
