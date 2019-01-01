using ComicBase.OnlineComicApiProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Factory
{
    public class OnlineCatalogProviderFactory : IOnlineComicProviderFactory
    {
        public IOnlineCatalogProvider GetProvider(ProviderType providerType, string apiKey)
        {
            switch (providerType)
            {
                case ProviderType.ComicVine:
                    return new ComicVineProvider(apiKey);

                default:
                    throw new NotImplementedException("Provider type for " + providerType + " not implemented.");

            }
        }
    }
}
