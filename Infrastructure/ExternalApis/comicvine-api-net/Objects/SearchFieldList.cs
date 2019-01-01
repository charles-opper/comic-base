using System.Collections.Generic;
using System.Linq;
using Thoorium.Comicvine.Enums;
using Thoorium.Comicvine.Helpers;

namespace Thoorium.Comicvine.Objects
{
    public class SearchFieldList
    {
        public CharacterFields CharacterFields { get; set; }
        public ConceptFields ConceptFields { get; set; }
        public OriginFields OriginFields { get; set; }
        public ObjectFields ObjectFields { get; set; }
        public LocationFields LocationFields { get; set; }
        public IssueFields IssueFields { get; set; }
        public StoryArcFields StoryArcFields { get; set; }
        public VolumeFields VolumeFields { get; set; }
        public PublisherFields PublisherFields { get; set; }
        public PersonFields PersonFields { get; set; }
        public TeamFields TeamFields { get; set; }
        public VideoFields VideoFields { get; set; }

        public string GetFieldsAsQueryParameter()
        {
            List<string> _Fields = new List<string>();
            if (this.CharacterFields != CharacterFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.CharacterFields).Split(','));

            if (this.ConceptFields != ConceptFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.ConceptFields).Split(','));

            if (this.OriginFields != OriginFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.OriginFields).Split(','));

            if (this.ObjectFields != ObjectFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.ObjectFields).Split(','));

            if (this.LocationFields != LocationFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.LocationFields).Split(','));

            if (this.IssueFields != IssueFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.IssueFields).Split(','));

            if (this.StoryArcFields != StoryArcFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.StoryArcFields).Split(','));

            if (this.VolumeFields != VolumeFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.VolumeFields).Split(','));

            if (this.PublisherFields != PublisherFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.PublisherFields).Split(','));

            if (this.PersonFields != PersonFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.PersonFields).Split(','));

            if (this.TeamFields != TeamFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.TeamFields).Split(','));

            if (this.VideoFields != VideoFields.ALL)
                _Fields.AddRange(EnumHelper.CleanEnumAndReturnAsLowercaseString(this.VideoFields).Split(','));

            return string.Join(",", _Fields.Distinct());
        }
    }
}