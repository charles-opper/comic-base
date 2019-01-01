using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum IssueFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        CHARACTER_CREDITS = 1 << 2,
        CHARACTERS_DIED_IN = 1 << 3,
        CONCEPT_CREDITS = 1 << 4,
        COVER_DATE = 1 << 5,
        DATE_ADDED = 1 << 6,
        DATE_LAST_UPDATED = 1 << 7,
        DECK = 1 << 8,
        DESCRIPTION = 1 << 9,
        DISBANDED_TEAMS = 1 << 10,
        FIRST_APPEARANCE_CHARACTERS = 1 << 11,
        FIRST_APPEARANCE_CONCEPTS = 1 << 12,
        FIRST_APPEARANCE_LOCATIONS = 1 << 13,
        FIRST_APPEARANCE_OBJECTS = 1 << 14,
        FIRST_APPEARANCE_STORYARCS = 1 << 15,
        FIRST_APPEARANCE_TEAMS = 1 << 16,
        HAS_STAFF_REVIEW = 1 << 17,
        ID = 1 << 18,
        IMAGE = 1 << 19,
        ISSUE_NUMBER = 1 << 20,
        LOCATION_CREDITS = 1 << 21,
        NAME = 1 << 22,
        OBJECT_CREDITS = 1 << 23,
        PERSON_CREDITS = 1 << 24,
        SITE_DETAIL_URL = 1 << 25,
        STORE_DATE = 1 << 26,
        STORY_ARC_CREDITS = 1 << 27,
        TEAM_CREDITS = 1 << 28,
        TEAM_DISBANDED_IN = 1 << 29,
        VOLUME = 1 << 30
    }
}