using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum PromoFields
    {
        ALL = 0,
        API_DETAIL_URL = 1 << 0,
        DATE_ADDED = 1 << 1,
        DECK = 1 << 2,
        ID = 1 << 3,
        IMAGE = 1 << 4,
        LINK = 1 << 5,
        NAME = 1 << 6,
        RESOURCE_TYPE = 1 << 7,
        USER = 1 << 8
    }
}