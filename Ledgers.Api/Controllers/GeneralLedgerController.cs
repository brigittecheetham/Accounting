using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ledgers.Api.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Ledgers.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralLedgerController : ControllerBase
    {
        [HttpPost]
        [Route("postTransaction")]
        public IActionResult PostTransaction([FromBody]SourceTransactionDto sourceTractionDto)
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}