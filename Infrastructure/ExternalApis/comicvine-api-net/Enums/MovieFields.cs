using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum MovieFields
    {
        ALL = 0,
        API_DETAIL_URL = 1 << 0,
        BOX_OFFICE_REVENUE = 1 << 1,
        BUDGET = 1 << 2,
        CHARACTERS = 1 << 3,
        CONCEPTS = 1 << 4,
        DATE_ADDED = 1 << 5,
        DATE_LAST_UPDATED = 1 << 6,
        DECK = 1 << 7,
        DESCRIPTION = 1 << 8,
        DISTRIBUTOR = 1 << 9,
        HAS_STAFF_REVIEW = 1 << 10,
        ID = 1 << 11,
        IMAGE = 1 << 12,
        LOCATIONS = 1 << 13,
        NAME = 1 << 14,
        PRODUCERS = 1 << 15,
        RATING = 1 << 16,
        RELEASE_DATE = 1 << 17,
        RUNTIME = 1 << 18,
        SITE_DETAIL_URL = 1 << 19,
        STUDIOS = 1 << 20,
        TEAMS = 1 << 21,
        THINGS = 1 << 22,
        TOTAL_REVENUE = 1 << 23,
        WRITERS = 1 << 24
    }
}