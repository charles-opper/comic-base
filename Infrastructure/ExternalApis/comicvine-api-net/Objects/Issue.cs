using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Issue
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [DeserializeAs(Name = "character_credits")]
        public List<Character> CharacterCredits { get; set; }

        [DeserializeAs(Name = "character_died_in")]
        public Character CharacterDiedIn { get; set; }

        [DeserializeAs(Name = "concept_credits")]
        public List<Concept> ConceptCredits { get; set; }

        [DeserializeAs(Name = "cover_date")]
        public string CoverDate { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

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

        public Image Image { get; set; }

        [DeserializeAs(Name = "issue_number")]
        public string IssueNumer { get; set; }

        public string Id { get; set; }

        [DeserializeAs(Name = "issue_number")]
        public string IssueNumber { get; set; }

        [DeserializeAs(Name = "location_credits")]
        public List<Location> LocationCredits { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "object_credits")]
        public List<Object> ObjectCredits { get; set; }

        [DeserializeAs(Name = "person_credits")]
        public List<Person> PersonCredits { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "store_date")]
        public string StoreDate { get; set; }

        [DeserializeAs(Name = "story_arc_credits")]
        public List<StoryArc> StoryArcCredits { get; set; }

        [DeserializeAs(Name = "team_credits")]
        public List<Team> TeamCredits { get; set; }

        [DeserializeAs(Name = "team_disbanded_in")]
        public string TeamDisbandedIn { get; set; }

        public Volume Volume { get; set; }

        public string GetCorrectApiDetailUrl()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.ToLowerInvariant().Replace("/first_appeared_in_issue/", "/issue/");
        }

        public string GetIssueApiId()
        {
            string _ApiDetailUrl = GetCorrectApiDetailUrl();

            if (string.IsNullOrWhiteSpace(_ApiDetailUrl))
                return _ApiDetailUrl;

            return _ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}