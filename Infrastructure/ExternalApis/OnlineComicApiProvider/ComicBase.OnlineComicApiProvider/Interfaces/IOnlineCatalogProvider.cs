using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Interfaces
{
    public interface IOnlineCatalogProvider
    {
        IEnumerable<OnlineCatalogItem> GetCatalogItemsByTitle(string title);
    }
}
