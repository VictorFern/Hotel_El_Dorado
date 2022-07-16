using Hotel_El_Dorado.Data;
using Hotel_El_Dorado.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_El_Dorado.Business
{
    public class ClienteBusiness
    {

        public IConfiguration Configuration { get; }
        public ClienteBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor

        public ClienteModel BuscarClienteCedula(int cedula)
        {

            ClienteData clienteData = new ClienteData(Configuration);
            return clienteData.BuscarClienteCedula(cedula);
        }

    }
}
