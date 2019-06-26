using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NavigationApp.Model;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NavigationApp.Controllers
{
    [Produces("application/json")]  
    [Route("api/[controller]")]
    public class NavigationController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public NavMenu Get()
        {
            string menuJson = GetMenuJson();
            JsonSerializer serializer = new JsonSerializer();
            NavMenu menu = JsonConvert.DeserializeObject<NavMenu>(menuJson);
            return menu;
        }

        private string GetMenuJson() {
            StreamReader reader = new StreamReader("C:\\DB\\navigation-json-schema.json");
            string jsonData = "";
            using (reader) {
                jsonData = reader.ReadToEnd();
            }
            return jsonData;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
