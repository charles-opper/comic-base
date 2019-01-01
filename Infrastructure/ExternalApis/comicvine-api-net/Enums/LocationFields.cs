using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum LocationFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        COUNT_OF_ISSUE_APPEARANCES = 1 << 2,
        DATE_ADDED = 1 << 3,
        DATE_LAST_UPDATED = 1 << 4,
        DECK = 1 << 5,
        DESCRIPTION = 1 << 6,
        FIRST_APPEARED_IN_ISSUE = 1 << 7,
        ID = 1 << 8,
        IMAGE = 1 << 9,
        ISSUE_CREDITS = 1 << 10,
        MOVIES = 1 << 11,
        NAME = 1 << 12,
        SITE_DETAIL_URL = 1 << 13,
        START_YEAR = 1 << 14,
        STORY_ARC_CREDITS = 1 << 15,
        VOLUME_CREDITS = 1 << 16
    }
}