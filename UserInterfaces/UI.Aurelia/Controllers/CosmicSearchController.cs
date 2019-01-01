using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBase.OnlineComicApiProvider.Factory;
using ComicBase.OnlineComicApiProvider.Interfaces;
using ComicBase.Spa.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ComicBase.Spa.Controllers
{
    [Route("api/[controller]")]
    public class CosmicSearchController : ApiControllerBase
    {
        public CosmicSearchController(IOnlineComicProviderFactory factory, IConfiguration configuration, IOptions<AppConfig> options)
            : base(configuration, options)
        {
            _factory = factory;
        }

        // GET: api/CosmicSearch
        [HttpGet]
        public IEnumerable<OnlineCatalogItem> Get([FromQuery]string title)
        {
            var provider = _factory.GetProvider(ProviderType.ComicVine, AppConfig.ComicVineApiKey);

            return provider.GetCatalogItemsByTitle(title);
        }


        IOnlineComicProviderFactory _factory;
    }
}
