using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Hotel_El_Dorado.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hotel_El_Dorado.Business;

namespace Hotel_El_Dorado.Controllers
{
    [Route("Cliente")]
    public class ClienteController : Controller
    {

        public IConfiguration Configuration { get; }
        private readonly ILogger<ClienteController> _logger;
        private readonly IWebHostEnvironment _iweb;


        public ClienteController(IConfiguration configuration, ILogger<ClienteController> logger, IWebHostEnvironment iweb)
        {
            _logger = logger;
            _iweb = iweb;
            Configuration = configuration;
        } // constructor

        [Route("BuscarCedula")]
        [HttpPost]
        public ClienteModel BuscarClienteCedula(int cedula)
        {

            ClienteBusiness clienteBusiness = new ClienteBusiness(Configuration);

            return clienteBusiness.BuscarClienteCedula(cedula);
        }

    }
}
