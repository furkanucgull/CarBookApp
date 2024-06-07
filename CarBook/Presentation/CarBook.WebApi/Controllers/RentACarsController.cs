using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentACarsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetRentACarListByLocation(int locationId, bool isAvaible)
        {
            GetRentACarQuery getRentACarQuery = new GetRentACarQuery()
            {
                IsAvailable = isAvaible,
                LocationID = locationId,
            };
            var values = await _mediator.Send(getRentACarQuery);
            return Ok(values);
        }
    }
}
