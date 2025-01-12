using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optik.Application.Features.CQRS.Commands.ContactCommands;
using Optik.Application.Features.CQRS.Handlers.ContactHandlers.Write;
using Optik.Application.Features.CQRS.Queries.ContactQueries;

namespace Optik.Presentation;

[Route("api/[controller]")]
[ApiController]
public class ContactController : Controller
{
    // GET
    private readonly IMediator _mediator;

    public ContactController( IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        var value = await _mediator.Send(new GetContactQuery());
        return Ok(value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id) 
    {
        var value = await _mediator.Send(new GetContactByIdQuery(id));
        return Ok(value);
    }
    
    // POST api/values
    [HttpPost]
    public async Task<IActionResult> Post(CreataContactCommand command)
    {
        await _mediator.Send(command);
        return Ok("EKlendi");
    }

    // PUT api/values/5
    [HttpPut]
    public async Task<IActionResult> Put(UpdateContactCommand command)
    {
        await _mediator.Send(command);
        return Ok("Guncellendi");
    }

    // DELETE api/values/5
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new RemoveContactCommand(id));
        return Ok("Silindi");
    }
}