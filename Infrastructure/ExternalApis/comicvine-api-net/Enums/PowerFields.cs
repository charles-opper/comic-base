using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum PowerFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        CHARACTERS = 1 << 2,
        DATE_ADDED = 1 << 3,
        DATE_LAST_UPDATED = 1 << 4,
        DESCRIPTION = 1 << 5,
        ID = 1 << 6,
        NAME = 1 << 7,
        SITE_DETAIL_URL = 1 << 8
    }
}