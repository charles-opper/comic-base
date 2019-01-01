using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Person
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        public string Birth { get; set; }

        [DeserializeAs(Name = "count_of_issue_appearances")]
        public int CountOfIssueAppearances { get; set; }

        public string Country { get; set; }

        [DeserializeAs(Name = "created_characters")]
        public List<Character> CreatedCharacters { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string Hometown { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        public List<Issue> Issues { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "story_arc_credits")]
        public List<StoryArc> StoryArcCredits { get; set; }

        [DeserializeAs(Name = "volume_credits")]
        public List<Volume> VolumeCredits { get; set; }

        public string Website { get; set; }

        public string GetPersonApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}