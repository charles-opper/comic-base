using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum PublisherFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        CHARACTERS = 1 << 2,
        DATE_ADDED = 1 << 3,
        DATE_LAST_UPDATED = 1 << 4,
        DECK = 1 << 5,
        DESCRIPTION = 1 << 6,
        ID = 1 << 7,
        IMAGE = 1 << 8,
        LOCATION_ADDRESS = 1 << 9,
        LOCATION_CITY = 1 << 10,
        LOCATION_STATE = 1 << 11,
        NAME = 1 << 12,
        SITE_DETAIL_URL = 1 << 13,
        STORY_ARCS = 1 << 14,
        TEAMS = 1 << 15,
        VOLUMES = 1 << 16
    }
}