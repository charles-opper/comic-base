using RestSharp.Deserializers;

namespace Thoorium.Comicvine.Objects
{
    /// <remarks>Doesn't have a detailed api</remarks>
    public class Studio
    {
        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }
    }
}