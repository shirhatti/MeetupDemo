using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MeetupDemo.Controllers
{
    [Route("[controller]")]
    public class PocoController
    {
        [HttpGet("{id}")]
        public string GetValue(int id)
        {
            return "Value" + id;
        }

        [HttpPost]
        public Value PostValue([FromBody] Value value)
        {
            var foo = new Value()
            {
                Id = ++value.Id,
                Message = value.Message
            };
            return foo;
        }
    }
    public class Value
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
}
