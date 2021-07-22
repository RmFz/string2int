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

        [HttpGet]
        public int StringToInteger(string text)
        {
            int result = 0;
            try
            {
                List<int> filterNumberList = new List<int>();

                // filter number
                foreach (char digitValue in text)
                {
                    switch (digitValue)
                    {
                        case '0':
                            filterNumberList.Add(0);
                            break;
                        case '1':
                            filterNumberList.Add(1);
                            break;
                        case '2':
                            filterNumberList.Add(2);
                            break;
                        case '3':
                            filterNumberList.Add(3);
                            break;
                        case '4':
                            filterNumberList.Add(4);
                            break;
                        case '5':
                            filterNumberList.Add(5);
                            break;
                        case '6':
                            filterNumberList.Add(6);
                            break;
                        case '7':
                            filterNumberList.Add(7);
                            break;
                        case '8':
                            filterNumberList.Add(8);
                            break;
                        case '9':
                            filterNumberList.Add(9);
                            break;
                    }
                }    
                
                foreach (int valueIndex in filterNumberList)
                {
                    result *= 10;                       // set index position
                    result += valueIndex;               // add value position
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
