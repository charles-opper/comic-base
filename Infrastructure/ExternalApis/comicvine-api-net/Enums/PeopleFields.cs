using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum PeopleFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        BIRTH = 1 << 2,
        COUNT_OF_ISSUE_APPEARANCES = 1 << 3,
        COUNTRY = 1 << 4,
        DATE_ADDED = 1 << 5,
        DATE_LAST_UPDATED = 1 << 6,
        DEATH = 1 << 7,
        DECK = 1 << 8,
        DESCRIPTION = 1 << 9,
        EMAIL = 1 << 10,
        GENDER = 1 << 11,
        HOMETOWN = 1 << 12,
        ID = 1 << 13,
        IMAGE = 1 << 14,
        NAME = 1 << 15,
        SITE_DETAIL_URL = 1 << 16,
        WEBSITE = 1 << 17
    }
}