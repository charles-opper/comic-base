using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum VolumeFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        CHARACTER_CREDITS = 1 << 2,
        CONCEPT_CREDITS = 1 << 3,
        COUNT_OF_ISSUES = 1 << 4,
        DATE_ADDED = 1 << 5,
        DATE_LAST_UPDATED = 1 << 6,
        DECK = 1 << 7,
        DESCRIPTION = 1 << 8,
        FIRST_ISSUE = 1 << 9,
        ID = 1 << 10,
        IMAGE = 1 << 11,
        LAST_ISSUE = 1 << 12,
        LOCATION_CREDITS = 1 << 13,
        NAME = 1 << 14,
        OBJECT_CREDITS = 1 << 15,
        PERSON_CREDITS = 1 << 16,
        PUBLISHER = 1 << 17,
        SITE_DETAIL_URL = 1 << 18,
        START_YEAR = 1 << 19,
        TEAM_CREDITS = 1 << 20
    }
}