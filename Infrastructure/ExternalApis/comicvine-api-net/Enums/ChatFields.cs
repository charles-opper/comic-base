using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum ChatFields
    {
        ALL = 0,
        API_DETAIL_URL = 1 << 0,
        CHANNEL_NAME = 1 << 1,
        DECK = 1 << 2,
        IMAGE = 1 << 3,
        PASSWORD = 1 << 4,
        SITE_DETAIL_URL = 1 << 5,
        TITLE = 1 << 6
    }
}