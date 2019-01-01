using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    [DeserializeAs(Name = "thing")]
    public class Object
    {
        public string Aliases { get; set; }

        /// <remarks>The Api sends to /thing/ but should send to /object/. See GetCorrectApiDetailUrl() for the corrected url</remarks>
        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [DeserializeAs(Name = "count_of_issue_appearances")]
        public int CountOfIssueAppearances { get; set; }

        ///<summary>Date format is yyyy-mm-dd HH:MM:SS</summary>
        ///<remarks>a string type has been used instead of datetime to not having to deal with local time format</remarks>
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

        [DeserializeAs(Name = "start_year")]
        public string StartYear { get; set; }

        [DeserializeAs(Name = "story_arc_credits")]
        public List<StoryArc> StoryArcCredits { get; set; }

        [DeserializeAs(Name = "volume_credits")]
        public List<Volume> VolumeCredits { get; set; }

        public string GetCorrectApiDetailUrl()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.ToLowerInvariant().Replace("/thing/", "/object/");
        }

        public string GetObjectApiId()
        {
            string _ApiDetailUrl = GetCorrectApiDetailUrl();

            if (string.IsNullOrWhiteSpace(_ApiDetailUrl))
                return _ApiDetailUrl;

            return _ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}