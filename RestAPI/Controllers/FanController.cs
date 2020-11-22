using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

//Testing this
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

        // GET/Read api/<FanController>/Name/Tastic
        [HttpGet("Name/{name}")]
        public IEnumerable<FanOutput> GetByName(string name)
        {
            return FanData.FindAll(i => i.Name.Contains(name));
        }

        // GET/Read api/<FanController>/Temp/24
        [HttpGet("Temp/{temp}")]
        public IEnumerable<FanOutput> GetByTemp(int temp)
        {
            return FanData.FindAll(i => i.Temp.Equals(temp));
        }

        // GET/Read api/<FanController>/Humidity/59
        [HttpGet("Humidity/{humidity}")]
        public IEnumerable<FanOutput> GetByHumidity(int humidity)
        {
            return FanData.FindAll(i => i.Humidity.Equals(humidity));
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

        // Search api/fan/search/TempBelow?number=20
        [HttpGet]
        [Route("Search/TempBelow")]
        public IEnumerable<FanOutput> SearchTempBelow([FromQuery] double number)
        {
            return FanData.FindAll(i => i.Temp < number);
        }

        // Search api/fan/search/TempAbove?number=20
        [HttpGet]
        [Route("Search/TempAbove")]
        public IEnumerable<FanOutput> SearchTempAbove([FromQuery] double number)
        {
            return FanData.FindAll(i => i.Temp > number);
        }

        // Search api/fan/search/HumidityBelow?number=50
        [HttpGet]
        [Route("Search/HumidityBelow")]
        public IEnumerable<FanOutput> SearchHumidityBelow([FromQuery] double number)
        {
            return FanData.FindAll(i => i.Humidity < number);
        }

        // Search api/fan/search/HumidityAbove?number=50
        [HttpGet]
        [Route("Search/HumidityAbove")]
        public IEnumerable<FanOutput> SearchHumidityAbove([FromQuery] double number)
        {
            return FanData.FindAll(i => i.Humidity > number);
        }

        // Search with object parameter
        // Search api/fan/search?LowTemp=20
        [HttpGet]
        [Route("Search/")]
        public FanOutput Search([FromQuery] FilterFan filter)
        {
            return FanData.Find(i => i.Temp < filter.LowTemp);
        }
    }
}
