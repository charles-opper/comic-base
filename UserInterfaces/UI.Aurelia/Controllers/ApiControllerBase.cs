using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBase.Spa.Controllers
{
    [ApiController]
    public abstract class ApiControllerBase
    {
        public ApiControllerBase(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected string ConnectionString { get; set; }
    }
}
