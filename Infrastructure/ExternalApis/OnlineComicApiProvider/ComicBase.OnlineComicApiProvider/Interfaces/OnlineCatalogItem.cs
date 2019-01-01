using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Interfaces
{
    public class OnlineCatalogItem
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public string IssueNumber { get; set; }
        public DateTime CoverDate { get; set; }
    }
}
