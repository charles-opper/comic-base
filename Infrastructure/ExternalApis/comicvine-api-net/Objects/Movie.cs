using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Movie
    {
        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [DeserializeAs(Name = "box_office_revenue")]
        public string BoxOfficeRevenue { get; set; }

        public string Budget { get; set; }

        public List<Character> Characters { get; set; }

        public List<Concept> Concepts { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        //TODO: Validate with the API
        public string Distributor { get; set; }

        [DeserializeAs(Name = "has_staff_review")]
        public string HasStaffReview { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        public List<Location> Locations { get; set; }

        public string Name { get; set; }

        public List<Object> Objects { get; set; }

        //TODO: Validate with the API
        public string Producers { get; set; }

        public int Rating { get; set; }

        [DeserializeAs(Name = "release_date")]
        public string ReleaseDate { get; set; }

        public int Runtime { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        public Studio Studios { get; set; }

        public List<Team> Teams { get; set; }

        [DeserializeAs(Name = "total_revenue")]
        public string TotalRevenue { get; set; }

        public List<Writer> Writers { get; set; }

        public string GetMovieApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}