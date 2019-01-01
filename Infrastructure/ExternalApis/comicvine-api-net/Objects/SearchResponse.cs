using System.Collections.Generic;

namespace Thoorium.Comicvine.Objects
{
    public class SearchResponse : Response
    {
        public Result Results { get; set; }

        public class Result
        {
            public List<Character> Characters { get; set; }
            public List<Concept> Concepts { get; set; }
            public List<Origin> Origins { get; set; }
            public List<Object> Objects { get; set; }
            public List<Location> Locations { get; set; }
            public List<Issue> Issues { get; set; }
            public List<StoryArc> StoryArcs { get; set; }
            public List<Volume> Volumes { get; set; }
            public List<Publisher> Publishers { get; set; }
            public List<Person> Persons { get; set; }
            public List<Team> Teams { get; set; }
            public List<Video> Videos { get; set; }
        }
    }
}