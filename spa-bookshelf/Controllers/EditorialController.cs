using System;
using System.Collections.Generic;
using System.Linq;
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
        [Route("all")]
        public IEnumerable<Editorial> GetAllEditorials()
        {
            List<Editorial> editorials = new List<Editorial>();

            Editorial manningEditorial = new Editorial();
            manningEditorial.Name = "Manning";
            manningEditorial.Founded = 1990;
            manningEditorial.Origin = "United States";
            manningEditorial.Founder = "Marjan Bace";
            editorials.Add(manningEditorial);

            Editorial apressEditorial = new Editorial();
            apressEditorial.Name = "Apress";
            apressEditorial.Founded = 1999;
            apressEditorial.Origin = "United States";
            apressEditorial.Founder = "Gary Cornell";
            editorials.Add(apressEditorial);

            return editorials;
        }
    }
}
