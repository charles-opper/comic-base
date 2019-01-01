using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Concept
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [DeserializeAs(Name = "count_of_issue_appearances")]
        public int CountOfIssueAppearances { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        [DeserializeAs(Name = "first_appeared_in_issue")]
        public Issue FirstAppearedInIssue { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        [DeserializeAs(Name = "issue_credits")]
        public List<Issue> IssueCredits { get; set; }

        public List<Movie> Movies { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "volume_credits")]
        public List<Volume> VolumeCredits { get; set; }

        public string GetConceptApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}