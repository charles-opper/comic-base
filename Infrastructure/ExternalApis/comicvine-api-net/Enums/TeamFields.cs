using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum TeamFields
    {
        ALL = 0,
        ALIASES = 1 << 0,
        API_DETAIL_URL = 1 << 1,
        CHARACTER_ENEMIES = 1 << 2,
        CHARACTER_FRIENDS = 1 << 3,
        CHARACTERS = 1 << 4,
        COUNT_OF_ISSUE_APPEARANCES = 1 << 5,
        COUNT_OF_TEAM_MEMBERS = 1 << 6,
        DATE_ADDED = 1 << 7,
        DATE_LAST_UPDATED = 1 << 8,
        DECK = 1 << 9,
        DESCRIPTION = 1 << 10,
        DISBANDED_IN_ISSUES = 1 << 11,
        FIRST_APPEARED_IN_ISSUE = 1 << 12,
        ID = 1 << 13,
        IMAGE = 1 << 14,
        ISSUE_CREDITS = 1 << 15,
        ISSUES_DISBANED_IN = 1 << 16,
        MOVIES = 1 << 17,
        NAME = 1 << 18,
        PUBLISHER = 1 << 19,
        SITE_DETAIL_URL = 1 << 20,
        STORY_ARC_CREDITS = 1 << 21,
        VOLUME_CREDITS = 1 << 22
    }
}