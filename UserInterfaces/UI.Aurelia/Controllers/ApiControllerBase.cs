using ComicBase.Spa.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBase.Spa.Controllers
{
    [ApiController]
    public abstract class ApiControllerBase
    {
        public ApiControllerBase(IConfiguration configuration, IOptions<AppConfig> options)
        {
            AppConfig = options.Value;
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected AppConfig AppConfig { get; set; }

        protected string ConnectionString { get; set; }        
    }
}
