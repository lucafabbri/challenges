using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSServerless1.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerless1.Controllers
{
    [Route("api/CalculateSalesTaxes")]
    [ApiController]
    public class CalculateSalesTaxesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostOrder([FromBody] OrderDTO order)
        {
            return Ok(new ReceiptDTO(order.Items));
        }
    }
}