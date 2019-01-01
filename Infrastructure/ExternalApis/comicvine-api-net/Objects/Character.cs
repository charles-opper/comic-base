using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoorium.Comicvine.Objects
{
    public class Character
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        public string Birth { get; set; }

        [DeserializeAs(Name = "character_enemies")]
        public List<Character> CharacterEnemies { get; set; }

        [DeserializeAs(Name = "character_friends")]
        public List<Character> CharacterFriends { get; set; }

        [DeserializeAs(Name = "count_of_issue_appearances")]
        public int CountOfIssueAppearances { get; set; }

        public List<Creator> Creators { get; set; }

        ///<summary>Date format is yyyy-mm-dd HH:MM:SS</summary>
        ///<remarks>a string type has been used instead of datetime to not having to deal with local time format</remarks>
        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        [DeserializeAs(Name = "first_appeared_in_issue")]
        public Issue FirstAppearedInIssue { get; set; }

        public string Gender { get; set; }

        public string Id { get; set; }

        public Image Image { get; set; }

        [DeserializeAs(Name = "issue_credits")]
        public List<Issue> IssueCredits { get; set; }

        [DeserializeAs(Name = "issues_died_in")]
        public List<Issue> IssuesDiedIn { get; set; }

        public List<Movie> Movies { get; set; }

        public string Name { get; set; }

        public Origin Origin { get; set; }

        public List<Power> Powers { get; set; }

        public Publisher Publisher { get; set; }

        [DeserializeAs(Name = "real_name")]
        public string RealName { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "story_arc_credits")]
        public List<StoryArc> StoryArcCredits { get; set; }

        [DeserializeAs(Name = "team_enemies")]
        public List<Team> TeamEnemies { get; set; }

        [DeserializeAs(Name = "team_friends")]
        public List<Team> TeamFriends { get; set; }

        public List<Team> Teams { get; set; }

        [DeserializeAs(Name = "volume_credits")]
        public List<Volume> VolumeCredits { get; set; }

        [DeserializeAs(Name = "resource_type")]
        public string ResourceType { get; set; }

        public string GetCharacterApiId()
        {
            if (string.IsNullOrWhiteSpace(this.ApiDetailUrl))
                return this.ApiDetailUrl;

            return this.ApiDetailUrl.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}