using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Features.Produit.Commands;
using Service.Features.Produit.Queries;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly IMediator Mediator;
        public ProduitController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProduitCreateCmd cmd)
        {
            var produit = await Mediator.Send(cmd);
            return Ok(produit);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Find(int id)
        {
            var city = await Mediator.Send(new ProduitFindQuery(id));
            return city is null ? NotFound() : Ok(city);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await Mediator.Send(new ProduitDeleteCmd(id));
            return success ? Ok(success) : NotFound();
        }
        [HttpPut]
        public async Task<IActionResult> Update(ProduitUpdateCmd cmd)
        {
            var city = await Mediator.Send(cmd);
            return Ok(city);
        }

        [HttpGet]
        public async Task<IActionResult> FindAll()
        {
            var cities = await Mediator.Send(new ProduitListQuery());
            return Ok(cities);
        }
    }
}
