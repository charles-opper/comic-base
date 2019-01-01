using ComicBase.OnlineComicApiProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Thoorium.Comicvine.Api;
using Thoorium.Comicvine.Objects;

namespace ComicBase.OnlineComicApiProvider.Factory
{
    /// <summary>
    /// A ComicVine API service provider that retrieves comic book catalog data via the comicvine-api-net project.
    /// </summary>
    public class ComicVineProvider : IOnlineCatalogProvider
    {
        public ComicVineProvider(string apiKey)
        {
            _comicVineApiProxy = new Comicvine(apiKey);
        }

        /// <summary>
        /// Retrieve a list of online catalog items from ComicVine based on a search query via title.
        /// </summary>
        /// <param name="title">The comic book title for the search query.</param>
        /// <returns>An enumerable list of online catalog items.</returns>
        public IEnumerable<OnlineCatalogItem> GetCatalogItemsByTitle(string title)
        {
            var catalogItems = new List<OnlineCatalogItem>();

            var titleSearchFieldList = new SearchFieldList()
            {
                IssueFields = Thoorium.Comicvine.Enums.IssueFields.ALL
            };

            var response = _comicVineApiProxy.Search(title, titleSearchFieldList, Thoorium.Comicvine.Enums.RessourceType.ISSUE);

            if (response.Status_Code == "1")
            {
                response.Results.Issues.ForEach(i => {

                    DateTime.TryParse(i.CoverDate, out var coverDate);

                    catalogItems.Add(
                        new OnlineCatalogItem()
                        {
                            Title = i.Name,
                            CoverDate = coverDate,
                            IssueNumber = i.IssueNumber,
                            Description = i.Description,
                            Publisher = i.ApiDetailUrl
                        });

                });
            }

            return catalogItems;
        }

        private Comicvine _comicVineApiProxy;
    }
}
