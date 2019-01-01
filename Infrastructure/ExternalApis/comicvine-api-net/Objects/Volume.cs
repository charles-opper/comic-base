using RestSharp.Deserializers;
using System;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Volume
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [DeserializeAs(Name = "count_of_issues")]
        public int CountOfIssues { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        [DeserializeAs(Name = "first_issue")]
        public Issue FirstIssue { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        [DeserializeAs(Name = "last_issue")]
        public Issue LastIssue { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "start_year")]
        public string StartYear { get; set; }

        [DeserializeAs(Name = "resource_type")]
        public string ResourceType { get; set; }

        public string GetVolumeApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}