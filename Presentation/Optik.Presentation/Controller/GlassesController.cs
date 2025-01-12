using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optik.Application.Features.CQRS.Commands.GlassesCommands;
using Optik.Application.Features.CQRS.Queries.GlassesQueries;

namespace Optik.Presentation;

[Route("api/[controller]")]
[ApiController]
public class GlassesController : Controller
{
    // GET
    private readonly IMediator _mediator;

    public GlassesController( IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        var value = await _mediator.Send(new GetGlassesQuery());
        return Ok(value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id) 
    {
        var value = await _mediator.Send(new GetGlassesByIdQuery(id));
        return Ok(value);
    }
    
    // POST api/values
    [HttpPost]
    public async Task<IActionResult> Post(CreateGlassesCommand command)
    {
        await _mediator.Send(command);
        return Ok("EKlendi");
    }

    // PUT api/values/5
    [HttpPut]
    public async Task<IActionResult> Put(UpdateGlassesCommand command)
    {
        await _mediator.Send(command);
        return Ok("Guncellendi");
    }

    // DELETE api/values/5
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new RemoveGlassesCommand(id));
        return Ok("Silindi");
    }
}