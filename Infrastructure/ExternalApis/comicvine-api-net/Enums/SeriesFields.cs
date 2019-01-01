using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum SeriesFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        CHARACTER_CREDITS = 1 << 2,
        COUNT_OF_EPISODES = 1 << 3,
        DATE_ADDED = 1 << 4,
        DATE_LAST_UPDATED = 1 << 5,
        DECK = 1 << 6,
        DESCRIPTION = 1 << 7,
        FIRST_EPISODE = 1 << 8,
        ID = 1 << 9,
        IMAGE = 1 << 10,
        LAST_EPISODE = 1 << 11,
        LOCATION_CREDITS = 1 << 12,
        NAME = 1 << 13,
        PUBLISHER = 1 << 14,
        SITE_DETAIL_URL = 1 << 15,
        START_YEAR = 1 << 16
    }
}