using ComicBase.OnlineComicApiProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Factory
{
    /// <summary>
    /// The factory implementation for providing online comic providers.
    /// </summary>
    public class OnlineCatalogProviderFactory : IOnlineComicProviderFactory
    {
        /// <summary>
        /// Get an online comic provider based on a provider type and given require API key.
        /// </summary>
        /// <param name="providerType">The provider type (currently, only ComicVine implemented).</param>
        /// <param name="apiKey">The required API key.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when required API key not provided.</exception>
        public IOnlineCatalogProvider GetProvider(ProviderType providerType, string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException("Missing required parameter.", "apiKey");
            }

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
