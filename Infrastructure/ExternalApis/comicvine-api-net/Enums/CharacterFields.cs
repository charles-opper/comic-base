using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum CharacterFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        BIRTH = 1 << 2,
        CHARACTER_ENEMIES = 1 << 3,
        CHARACTER_FRIENDS = 1 << 4,
        COUNT_OF_ISSUE_APPEARANCES = 1 << 5,
        CREATORS = 1 << 6,
        DATE_ADDED = 1 << 7,
        DATE_LAST_UPDATED = 1 << 8,
        DECK = 1 << 9,
        DESCRIPTION = 1 << 10,
        FIRST_APPEARED_IN_ISSUE = 1 << 11,
        GENDER = 1 << 12,
        ID = 1 << 13,
        IMAGE = 1 << 14,
        ISSUE_CREDITS = 1 << 15,
        ISSUES_DIED_IN = 1 << 16,
        MOVIES = 1 << 17,
        NAME = 1 << 18,
        ORIGIN = 1 << 19,
        POWERS = 1 << 20,
        PUBLISHER = 1 << 21,
        REAL_NAME = 1 << 22,
        SITE_DETAIL_URL = 1 << 23,
        STORY_ARC_CREDITS = 1 << 24,
        TEAM_ENEMIES = 1 << 25,
        TEAM_FRIENDS = 1 << 26,
        TEAMS = 1 << 27,
        VOLUME_CREDITS = 1 << 28
    }
}