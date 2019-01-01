using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum PersonFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        BIRTH = 1 << 2,
        COUNT_OF_ISSUE_APPEARANCES = 1 << 3,
        COUNTRY = 1 << 4,
        CREATED_CHARACTERS = 1 << 5,
        DATE_ADDED = 1 << 6,
        DATE_LAST_UPDATED = 1 << 7,
        DEATH = 1 << 8,
        DECK = 1 << 9,
        DESCRIPTION = 1 << 10,
        EMAIL = 1 << 11,
        GENDER = 1 << 12,
        HOMETOWN = 1 << 13,
        ID = 1 << 14,
        IMAGE = 1 << 15,
        ISSUE_CREDITS = 1 << 16,
        NAME = 1 << 17,
        SITE_DETAIL_URL = 1 << 18,
        STORY_ARC_CREDITS = 1 << 19,
        VOLUME_CREDITS = 1 << 20,
        WEBSITE = 1 << 21
    }
}