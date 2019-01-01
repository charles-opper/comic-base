using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum EpisodeFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        CHARACTER_CREDITS = 1 << 2,
        CHARACTERs_DIED_IN = 1 << 3,
        CONCEPT_CREDITS = 1 << 4,
        AIR_DATE = 1 << 5,
        DATE_ADDED = 1 << 6,
        DATE_LAST_UPDATED = 1 << 7,
        DECK = 1 << 8,
        DESCRIPTION = 1 << 9,
        FIRST_APPEARANCE_CHARACTERS = 1 << 10,
        FIRST_APPEARANCE_CONCEPTS = 1 << 11,
        FIRST_APPEARANCE_LOCATIONS = 1 << 12,
        FIRST_APPEARANCE_OBJECTS = 1 << 13,
        FIRST_APPEARANCE_STORYARCS = 1 << 14,
        FIRST_APPEARANCE_TEAMS = 1 << 15,
        HAS_STAFF_REVIEW = 1 << 16,
        ID = 1 << 17,
        IMAGE = 1 << 18,
        EPISODE_NUMBER = 1 << 19,
        LOCATION_CREDITS = 1 << 20,
        NAME = 1 << 21,
        OBJECT_CREDITS = 1 << 22,
        PERSON_CREDITS = 1 << 23,
        SITE_DETAIL_URL = 1 << 24,
        STORY_ARC_CREDITS = 1 << 25,
        TEAM_CREDITS = 1 << 26,
        SERIES = 1 << 27
    }
}