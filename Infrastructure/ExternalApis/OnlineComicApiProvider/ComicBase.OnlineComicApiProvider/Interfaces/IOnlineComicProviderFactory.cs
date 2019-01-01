using ComicBase.OnlineComicApiProvider.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Interfaces
{
    /// <summary>
    /// A factory interface for working with online comic book API providers.
    /// This should be used for dependency injection services for providing an online comic book provider.
    /// </summary>
    public interface IOnlineComicProviderFactory
    {
        IOnlineCatalogProvider GetProvider(ProviderType providerType, string apiKey);
    }
}
