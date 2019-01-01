using RestSharp.Deserializers;
using System;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Video
    {
        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        public string Deck { get; set; }

        [DeserializeAs(Name = "hd_url")]
        public string HDUrl { get; set; }

        [DeserializeAs(Name = "high_url")]
        public string HighUrl { get; set; }

        [DeserializeAs(Name = "low_url")]
        public string LowUrl { get; set; }

        public string Id { get; set; }

        [DeserializeAs(Name = "length_seconds")]
        public int LengthSeconds { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "publish_date")]
        public string PublishDate { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        public string Url { get; set; }

        public string User { get; set; }

        [DeserializeAs(Name = "video_type")]
        public string VideoType { get; set; }

        [DeserializeAs(Name = "youtube_id")]
        public string YoutubeId { get; set; }

        [DeserializeAs(Name = "resource_type")]
        public string ResourceType { get; set; }

        public string GetVideoApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}