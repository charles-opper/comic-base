using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    [DeserializeAs(Name = "story_arc")]
    public class StoryArc
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

        public List<Episode> Episodes { get; set; }

        [DeserializeAs(Name = "first_appeared_in_episode")]
        public Episode FirstAppearedInEpisode { get; set; }

        [DeserializeAs(Name = "first_appeared_in_issue")]
        public Issue FirstAppearedInIssue { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        public List<Issue> Issues { get; set; }

        public List<Movie> Movies { get; set; }

        public string Name { get; set; }

        public Publisher Publisher { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        public string GetStoryArcApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}