using Application.Features.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class IrisFlowerController : BaseController
    {
        public IrisFlowerController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateIrisFlowerCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
