using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hotel_El_Dorado.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_El_Dorado.Models;
namespace Hotel_El_Dorado.Business
{
    public class HomeBusiness
    {
        public IConfiguration Configuration { get; }
        public HomeBusiness(IConfiguration configuration)
        {
            Configuration = configuration;
        } // constructor
        public HomeModel ObtenerHome() { 
            HomeData homeData = new HomeData(Configuration);
            return homeData.ObtenerHome();
        }
    }
}
