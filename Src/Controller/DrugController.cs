using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PloomesPraticalTest.Data;
using PloomesPraticalTest.Src.Models;

namespace PloomesPraticalTest.Src.Controller
{
    [ApiController]
    [Route("v1/drug")]
    public class DrugController : ControllerBase
    {
    
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Drug>> Post([FromServices] DrugContext contexto,[FromBody] Drug model)
        {
           
            contexto.Drugs.Add(model);
            await contexto.SaveChangesAsync();
            return model;
        }
    }
} 