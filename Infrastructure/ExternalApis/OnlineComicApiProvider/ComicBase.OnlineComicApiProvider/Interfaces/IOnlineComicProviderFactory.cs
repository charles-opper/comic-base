using ComicBase.OnlineComicApiProvider.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Interfaces
{
    public interface IOnlineComicProviderFactory
    {
        IOnlineCatalogProvider GetProvider(ProviderType providerType, string apiKey);
    }
}
