using System;

namespace Thoorium.Comicvine.Enums
{
    [Flags]
    public enum RessourceType
    {
        ALL = 0,
        CHARACTER = 1 << 0,
        CONCEPT = 1 << 1,
        ORIGIN = 1 << 2,
        OBJECT = 1 << 3,
        LOCATION = 1 << 4,
        ISSUE = 1 << 5,
        STORY_ARC = 1 << 6,
        VOLUME = 1 << 7,
        PUBLISHER = 1 << 8,
        PERSON = 1 << 9,
        TEAM = 1 << 10,
        VIDEO = 1 << 11
    }
}