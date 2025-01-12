using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optik.Application.Features.CQRS.Commands.FooterCommands;
using Optik.Application.Features.CQRS.Queries.FooterQueries;

namespace Optik.Presentation;

[Route("api/[controller]")]
[ApiController]
public class FooterController : Controller
{
    private readonly IMediator _mediator;

    public FooterController( IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        var value = await _mediator.Send(new GetFooterQuery());
        return Ok(value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id) 
    {
        var value = await _mediator.Send(new GetFooterByIdQuery(id));
        return Ok(value);
    }
    
    // POST api/values
    [HttpPost]
    public async Task<IActionResult> Post(CreateFooterCommand command)
    {
        await _mediator.Send(command);
        return Ok("EKlendi");
    }

    // PUT api/values/5
    [HttpPut]
    public async Task<IActionResult> Put(UpdateFooterCommand command)
    {
        await _mediator.Send(command);
        return Ok("Guncellendi");
    }

    // DELETE api/values/5
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new RemoveFooterCommand(id));
        return Ok("Silindi");
    }
}