using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessengerClientWinForms;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessengerController : ControllerBase
    {
        static List<Message> ListOfMessanges = new List<Message>();

        // GET api/<Messanger>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string OutputString = "Not found";
            if ((id < ListOfMessanges.Count) && (id >= 0))
            {
                OutputString = JsonConvert.SerializeObject(ListOfMessanges[id]);

            }
            Console.WriteLine(String.Format("Message requested № {0} : {1}", id, OutputString));

            return OutputString;
        }

        // POST api/<Messanger>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            ListOfMessanges.Add(msg);
            Console.WriteLine(String.Format("Всего сообщений: {0} Посланное сообщение: {1}", ListOfMessanges.Count, msg));
            //return new NoContentResult();
            return new OkResult();
        }
    }
}
