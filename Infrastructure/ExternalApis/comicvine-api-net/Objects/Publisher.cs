using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Publisher
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        public List<Character> Characters { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        [DeserializeAs(Name = "location_address")]
        public string LocationAddress { get; set; }

        [DeserializeAs(Name = "location_city")]
        public string LocationCity { get; set; }

        [DeserializeAs(Name = "location_state")]
        public string LocationState { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "story_arcs")]
        public List<StoryArc> StoryArcs { get; set; }

        public List<Team> Teams { get; set; }

        public List<Volume> Volumes { get; set; }

        public string GetPublisherApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}