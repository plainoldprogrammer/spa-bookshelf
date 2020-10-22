using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace spa_bookshelf.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EditorialController : ControllerBase
    {
        private readonly ILogger<EditorialController> _logger;

        public EditorialController(ILogger<EditorialController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAllEditorials")]
        public IEnumerable<String> GetAllEditorials()
        {
            List<String> editorials = new List<String>();

            editorials.Add("Manning");
            editorials.Add("Apress");
            editorials.Add("Pearson");
            editorials.Add("Packt");

            return editorials;
        }
    }
}
