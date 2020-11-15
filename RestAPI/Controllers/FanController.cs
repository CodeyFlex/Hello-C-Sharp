using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib.model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FanController : ControllerBase
    {
        //List of data
        private static List<FanOutput> FanData = new List<FanOutput>()
        {
            new FanOutput(0, "Fan Fanner", 20, 33),
            new FanOutput(1, "Fan Tastic", 24, 55),
            new FanOutput(2, "Fan Nominal", 22, 44),
            new FanOutput(3, "Fan T You", 17, 45),
            new FanOutput(4, "Fan 3000", 19, 59)
        };

        // GET/Read: api/<FanController>
        [HttpGet]
        public IEnumerable<FanOutput> Get()
        {
            return FanData;
        }

        // GET/Read api/<FanController>/5
        [HttpGet("{id}")]
        public FanOutput GetById(int id)
        {
            return FanData.Find(i => i.Id == id);
        }

        // POST/Create api/<FanController>
        [HttpPost]
        public void Post([FromBody] FanOutput value)
        {
            FanData.Add(value);
        }

        // PUT/Update api/<FanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FanOutput value)
        {
            FanOutput fanOutput = GetById(id); 
            if (fanOutput != null) {
                fanOutput.Id = value.Id;
                fanOutput.Name = value.Name;
                fanOutput.Temp = value.Temp;
                fanOutput.Humidity = value.Humidity; 
            }
        }

        // DELETE api/<FanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FanOutput fanOutput = GetById(id); 
            FanData.Remove(fanOutput);
        }
    }
}
