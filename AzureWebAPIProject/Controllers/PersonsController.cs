using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AzureWebAPIProject.Models;
using Microsoft.Extensions.Logging;

namespace AzureWebAPIProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly MasterContext _context;
        private readonly ILogger<PersonsController> _logger;

        public PersonsController(MasterContext context, ILogger<PersonsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            _logger.LogInformation("Getting all persons");
            return _context.Persons.ToArray();
        }

        [HttpGet("view")]
        public IActionResult View()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/html");
        }
    }
}
