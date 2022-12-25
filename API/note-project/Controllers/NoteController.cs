using Microsoft.AspNetCore.Mvc;

namespace note_project.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class NoteController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

        [HttpPost]
        public string Post()
        {
            return "Hello World";
        }

        [HttpPut]
        public string Put()
        {
            return "Hello World";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Hello World";
        }
    }   
}