using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PloomesPraticalTest.Data;
using PloomesPraticalTest.Src.Models;

namespace PloomesPraticalTest.Src.Controller
{
    [ApiController]
    [Route("v1/drug")]
    [Produces("application/json")]
    public class DrugController : ControllerBase
    {
        ///<summary>
        ///Displays all items in the database
        ///</summary>        
        ///<response code="404">If the item was not found</response>
        [HttpGet]
        [Route("")]
        public IActionResult Get([FromServices] DrugContext context)
        {

            var ListDrugs = context.Drugs.ToList();
            if (ListDrugs.Count == 0)
            {
                return NotFound();              
            }
            else
            {
                return Ok(ListDrugs);
            }
        }

        ///<summary>
        ///Adds new items to the database
        ///</summary>
        ///<response code="201">Returns the newly created item</response>
        ///<response code="400">If the item is null</response>
        [HttpPost]      
        [Route("")]
        public async Task<ActionResult<Drug>> Post([FromServices] DrugContext context,[FromBody] Drug model)
        {       
            context.Drugs.Add(model);
            await context.SaveChangesAsync();
            return Created("v1/drug", model);            
        }
    }
} 