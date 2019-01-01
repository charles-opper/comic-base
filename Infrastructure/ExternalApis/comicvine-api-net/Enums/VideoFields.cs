using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum VideoFields
    {
        ALL = 0,
        API_DETAIL_URL = 1 << 0,
        DECK = 1 << 1,
        HD_URL = 1 << 2,
        HIGH_URL = 1 << 3,
        ID = 1 << 4,
        IMAGE = 1 << 5,
        LENGTH_SECONDS = 1 << 6,
        LOW_URL = 1 << 7,
        NAME = 1 << 8,
        PUBLISH_DATE = 1 << 9,
        SITE_DETAIL_URL = 1 << 10,
        URL = 1 << 11,
        USER = 1 << 12
    }
}