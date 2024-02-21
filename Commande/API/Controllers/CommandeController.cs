
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Features.Commande.Queries.GetDetail;

namespace API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CommandeController : BaseController
{

    private readonly IMediator _mediator;
    public CommandeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("get", Name = "GetCommande")]
    public async Task<ActionResult<CommandeDto>> Get(int id)
    {
        var obj = await _mediator.Send(new GetDetailCommandeQuery() { CommandeId = id});
        if (obj == null)
        {
            return NotFound();
        }
        return Ok(obj);
    }



}
