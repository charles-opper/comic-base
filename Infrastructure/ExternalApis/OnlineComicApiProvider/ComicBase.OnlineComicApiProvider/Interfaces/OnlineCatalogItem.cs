using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Interfaces
{
    /// <summary>
    /// A basic online catalog item with common fields that can be used between all online comic book providers.
    /// </summary>
    public class OnlineCatalogItem
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public string IssueNumber { get; set; }
        public DateTime CoverDate { get; set; }
    }
}
