using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Origin
    {
        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [DeserializeAs(Name = "character_set")]
        public object CharacterSet { get; set; }

        public List<Character> Characters { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public object Profiles { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        public string GetOriginApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}