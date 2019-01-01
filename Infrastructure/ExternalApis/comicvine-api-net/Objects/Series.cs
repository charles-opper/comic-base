using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Series
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        public List<Character> Characters { get; set; }

        [DeserializeAs(Name = "count_of_episodes")]
        public int CountOfEpisodes { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        public List<Episode> Episodes { get; set; }

        [DeserializeAs(Name = "first_episode")]
        public Episode FirstEpisode { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        [DeserializeAs(Name = "last_episode")]
        public Episode LastEpisode { get; set; }

        public string Name { get; set; }

        public Publisher Publisher { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "start_year")]
        public string StartYear { get; set; }

        public string GetSeriesApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}