using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StringToIntFunction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringToIntegerController : ControllerBase
    {
        public StringToIntegerController()
        {

        }

        [HttpGet("StringToInteger")]
        public int StringToInteger(string text)
        {
            int result = 0;
            try
            {
                // TODO: coding here

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
