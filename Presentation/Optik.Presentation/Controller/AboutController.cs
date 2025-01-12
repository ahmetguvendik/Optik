using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optik.Application.Features.CQRS.Commands.AboutCommands;
using Optik.Application.Features.CQRS.Queries.AboutQueries;

namespace Optik.Presentation;

[Route("api/[controller]")]
[ApiController]
public class AboutController : Controller
{
    private readonly IMediator _mediator;

    public AboutController( IMediator mediator)
    {
         _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        var value = await _mediator.Send(new GetAboutQuery());
        return Ok(value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var value = await _mediator.Send(new GetAboutByIdQuery(id));
        return Ok(value);
    }
    
    // POST api/values
    [HttpPost]
    public async Task<IActionResult> Post(CreateAboutCommand command)
    {
        await _mediator.Send(command);
        return Ok("EKlendi");
    }

    // PUT api/values/5
    [HttpPut]
    public async Task<IActionResult> Put(UpdateAboutCommond command)
    {
        await _mediator.Send(command);
        return Ok("Guncellendi");
    }

    // DELETE api/values/5
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new RemoveAboutCommand(id));
        return Ok("Silindi");
    }
}