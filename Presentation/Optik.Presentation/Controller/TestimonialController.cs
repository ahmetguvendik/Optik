using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optik.Application.Features.CQRS.Commands.TestimonialCommands;
using Optik.Application.Features.CQRS.Queries.TestimonialQueries;

namespace Optik.Presentation;

[Route("api/[controller]")]
[ApiController]
public class TestimonialController : Controller
{ // GET
    private readonly IMediator _mediator;

    public TestimonialController( IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        var value = await _mediator.Send(new GetTestimonialQuery());
        return Ok(value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id) 
    {
        var value = await _mediator.Send(new GetTestimonialByIdQuery(id));
        return Ok(value);
    }
    
    // POST api/values
    [HttpPost]
    public async Task<IActionResult> Post(CreateTestimonialCommand command)
    {
        await _mediator.Send(command);
        return Ok("EKlendi");
    }

    // PUT api/values/5
    [HttpPut]
    public async Task<IActionResult> Put(UpdateTestimonialCommand command)
    {
        await _mediator.Send(command);
        return Ok("Guncellendi");
    }

    // DELETE api/values/5
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new RemoveTestimonialCommand(id));
        return Ok("Silindi");
    }
}