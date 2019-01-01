using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Episode
    {
        [DeserializeAs(Name = "air_date")]
        public string AirDate { get; set; }

        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [DeserializeAs(Name = "character_credits")]
        public List<Character> CharacterCredits { get; set; }

        [DeserializeAs(Name = "character_died_in")]
        public Character CharacterDiedIn { get; set; }

        [DeserializeAs(Name = "concept_credits")]
        public List<Concept> ConceptCredits { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        [DeserializeAs(Name = "episode_number")]
        public string EpisodeNumber { get; set; }

        [DeserializeAs(Name = "first_appearance_characters")]
        public List<Character> FirstAppearanceCharacters { get; set; }

        [DeserializeAs(Name = "first_appearance_concepts")]
        public List<Concept> FirstAppearanceConcepts { get; set; }

        [DeserializeAs(Name = "first_appearance_locations")]
        public List<Location> FirstAppearanceLocations { get; set; }

        [DeserializeAs(Name = "first_appearance_objects")]
        public List<Object> FirstAppearanceObjects { get; set; }

        [DeserializeAs(Name = "first_appearance_storyarcs")]
        public List<StoryArc> FirstAppearanceStoryArcs { get; set; }

        [DeserializeAs(Name = "first_appearance_teams")]
        public List<Team> FirstAppearanceTeams { get; set; }

        [DeserializeAs(Name = "has_staff_review")]
        public string HasStaffReview { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        [DeserializeAs(Name = "location_credits")]
        public List<Location> LocationCredits { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "object_credits")]
        public List<Object> ObjectCredits { get; set; }

        public Series Series { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "story_arc_credits")]
        public List<StoryArc> StoryArcCredits { get; set; }

        [DeserializeAs(Name = "team_credits")]
        public List<Team> TeamCredits { get; set; }

        [DeserializeAs(Name = "resource_type")]
        public string ResourceType { get; set; }

        public string GetEpisodeApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}