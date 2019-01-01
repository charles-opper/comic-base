using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum OriginFields
    {
        ALL = 0,
        API_DETAIL_URL = 1 << 0,
        CHARACTER_SET = 1 << 1,
        ID = 1 << 2,
        NAME = 1 << 3,
        PROFILES = 1 << 4,
        SITE_DETAIL_URL = 1 << 5
    }
}