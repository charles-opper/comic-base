using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Interfaces
{
    /// <summary>
    /// Interface for defining a contract of required operations for an online comic book provider.
    /// </summary>
    public interface IOnlineCatalogProvider
    {
        IEnumerable<OnlineCatalogItem> GetCatalogItemsByTitle(string title);
    }
}
