using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[ApiController]

public class CommandeController : ControllerBase
{

    [HttpGet]
    [Route("Intermediare")]
   
    public IActionResult Get()
    {
        var cmd = new CommandeDtos
        { DateCommande = DateTime.Now , Id = Guid.NewGuid(), NomClient = "Adil"};
        if (true)
        {
            return Ok(cmd);
        }
        //try
        //{
        //    return NotFound();


        //}
        //catch (Exception)
        //{

        //    return BadRequest();
        //}
         

    }
    //[HttpPost]
    //public IActionResult Post()
    //{

    //    //try
    //    //{
    //     return NotFound();


    //    //}
    //    //catch (Exception)
    //    //{

    //    //    return BadRequest();
    //    //}


    //}


    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Route("ajouter")]

    public ActionResult<CommandeDtos> Ajouter([FromBody] CommandeDtos obj)
    {

        return Ok(obj);
    }

   

}
