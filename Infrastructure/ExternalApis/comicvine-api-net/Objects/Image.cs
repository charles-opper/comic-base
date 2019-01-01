using RestSharp.Deserializers;

namespace Thoorium.Comicvine.Objects
{
    public class Image
    {
        [DeserializeAs(Name = "icon_url")]
        public string IconUrl { get; set; }

        [DeserializeAs(Name = "medium_url")]
        public string MediumUrl { get; set; }

        [DeserializeAs(Name = "screen_url")]
        public string ScreenUrl { get; set; }

        [DeserializeAs(Name = "small_url")]
        public string SmallUrl { get; set; }

        [DeserializeAs(Name = "super_url")]
        public string SuperUrl { get; set; }

        [DeserializeAs(Name = "thumb_url")]
        public string ThumbUrl { get; set; }

        [DeserializeAs(Name = "tiny_url")]
        public string TinyUrl { get; set; }
    }
}