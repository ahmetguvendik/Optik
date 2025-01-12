using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optik.Application.Features.CQRS.Commands.GlassCommands;
using Optik.Application.Features.CQRS.Queries.GlassQueries;

namespace Optik.Presentation;

[Route("api/[controller]")]
[ApiController]
public class GlassController : Controller
{
    // GET
    private readonly IMediator _mediator;

    public GlassController( IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        var value = await _mediator.Send(new GetGlassQuery());
        return Ok(value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id) 
    {
        var value = await _mediator.Send(new GetGlassByIdQuery(id));
        return Ok(value);
    }
    
    // POST api/values
    [HttpPost]
    public async Task<IActionResult> Post(CreateGlassCommand command)
    {
        await _mediator.Send(command);
        return Ok("EKlendi");
    }

    // PUT api/values/5
    [HttpPut]
    public async Task<IActionResult> Put(UpdateGlassCommand command)
    {
        await _mediator.Send(command);
        return Ok("Guncellendi");
    }

    // DELETE api/values/5
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new RemoveGlassCommand(id));
        return Ok("Silindi");
    }
}