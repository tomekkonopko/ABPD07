using ABPD07.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABPD07.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IDbService _service;

        public ClientController(IDbService Dbservice)
        {
            _service = Dbservice;
        }

        [HttpDelete("{idClient}")]
        public IActionResult deleteClient(int idClient)
        {
            int result = _service.DeleteClient(idClient);
            if (result != 0)
            {
                return StatusCode(400, "Nie mozna usunac uzytkownika");
            }
            else
            {
                return Ok("Usunięto ID-> " + idClient);
            }

        }
    }
}
