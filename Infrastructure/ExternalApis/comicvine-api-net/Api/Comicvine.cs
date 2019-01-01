using RestSharp;
using System.Collections.Generic;
using System.Linq;
using Thoorium.Comicvine.Enums;
using Thoorium.Comicvine.Helpers;
using Thoorium.Comicvine.Objects;

namespace Thoorium.Comicvine.Api
{
    public class Comicvine
    {
        private const string COMICVINE_HOST = "www.comicvine.com";
        private string fApiKey = "";

        public Comicvine(string ApiKey)
        {
            fApiKey = ApiKey;
        }

        public CharacterResponse GetCharacter(string CharacterApiId, CharacterFields CharacterFields = CharacterFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Character.Resource + "/" + CharacterApiId;

            Parameter _FieldsParam = null;
            if (CharacterFields != CharacterFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Character.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(CharacterFields), ParameterType.QueryString);

            return GetResource<CharacterResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public ConceptResponse GetConcept(string ConceptApiId, ConceptFields ConceptFields = ConceptFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Concept.Resource + "/" + ConceptApiId;

            Parameter _FieldsParam = null;
            if (ConceptFields != ConceptFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Concept.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(ConceptFields), ParameterType.QueryString);

            return GetResource<ConceptResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public EpisodeResponse GetEpisode(string EpisodeApiId, EpisodeFields EpisodeFields = EpisodeFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Episode.Resource + "/" + EpisodeApiId;

            Parameter _FieldsParam = null;
            if (EpisodeFields != EpisodeFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Episode.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(EpisodeFields), ParameterType.QueryString);

            return GetResource<EpisodeResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public IssueResponse GetIssue(string IssueApiId, IssueFields IssueFields = IssueFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Issue.Resource + "/" + IssueApiId;

            Parameter _FieldsParam = null;
            if (IssueFields != IssueFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Issue.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(IssueFields), ParameterType.QueryString);

            return GetResource<IssueResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public LocationResponse GetLocation(string LocationApiId, LocationFields LocationFields = LocationFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Location.Resource + "/" + LocationApiId;

            Parameter _FieldsParam = null;
            if (LocationFields != LocationFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Location.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(LocationFields), ParameterType.QueryString);

            return GetResource<LocationResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public MovieResponse GetMovie(string MovieApiId, MovieFields MovieFields = MovieFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Movie.Resource + "/" + MovieApiId;

            Parameter _FieldsParam = null;
            if (MovieFields != MovieFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Movie.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(MovieFields), ParameterType.QueryString);

            return GetResource<MovieResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public ObjectResponse GetObject(string ObjectApiId, ObjectFields ObjectFields = ObjectFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Object.Resource + "/" + ObjectApiId;

            Parameter _FieldsParam = null;
            if (ObjectFields != ObjectFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Object.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(ObjectFields), ParameterType.QueryString);

            return GetResource<ObjectResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public OriginResponse GetOrigin(string OriginApiId, OriginFields OriginFields = OriginFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Origin.Resource + "/" + OriginApiId;

            Parameter _FieldsParam = null;
            if (OriginFields != OriginFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Origin.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(OriginFields), ParameterType.QueryString);

            return GetResource<OriginResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public PersonResponse GetPerson(string PersonApiId, PersonFields PersonFields = PersonFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Person.Resource + "/" + PersonApiId;

            Parameter _FieldsParam = null;
            if (PersonFields != PersonFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Person.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(PersonFields), ParameterType.QueryString);

            return GetResource<PersonResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public PowerResponse GetPower(string PowerApiId, PowerFields PowerFields = PowerFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Power.Resource + "/" + PowerApiId;

            Parameter _FieldsParam = null;
            if (PowerFields != PowerFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Power.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(PowerFields), ParameterType.QueryString);

            return GetResource<PowerResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public PublisherResponse GetPublisher(string PublisherApiId, PublisherFields PublisherFields = PublisherFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Publisher.Resource + "/" + PublisherApiId;

            Parameter _FieldsParam = null;
            if (PublisherFields != PublisherFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Publisher.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(PublisherFields), ParameterType.QueryString);

            return GetResource<PublisherResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public SeriesResponse GetSeries(string SeriesApiId, SeriesFields SeriesFields = SeriesFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Series.Resource + "/" + SeriesApiId;

            Parameter _FieldsParam = null;
            if (SeriesFields != SeriesFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Series.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(SeriesFields), ParameterType.QueryString);

            return GetResource<SeriesResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public StoryArcResponse GetStoryArc(string StoryArcApiId, StoryArcFields StoryArcFields = StoryArcFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.StoryArc.Resource + "/" + StoryArcApiId;

            Parameter _FieldsParam = null;
            if (StoryArcFields != StoryArcFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.StoryArc.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(StoryArcFields), ParameterType.QueryString);

            return GetResource<StoryArcResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public TeamResponse GetTeam(string TeamApiId, TeamFields TeamFields = TeamFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Team.Resource + "/" + TeamApiId;

            Parameter _FieldsParam = null;
            if (TeamFields != TeamFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Team.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(TeamFields), ParameterType.QueryString);

            return GetResource<TeamResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public VideoResponse GetVideo(string VideoApiId, VideoFields VideoFields = VideoFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Video.Resource + "/" + VideoApiId;

            Parameter _FieldsParam = null;
            if (VideoFields != VideoFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Video.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(VideoFields), ParameterType.QueryString);

            return GetResource<VideoResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public VolumeResponse GetVolume(string VolumeApiId, VolumeFields VolumeFields = VolumeFields.ALL)
        {
            string _RequestResourceUrl = ApiResources.Volume.Resource + "/" + VolumeApiId;

            Parameter _FieldsParam = null;
            if (VolumeFields != VolumeFields.ALL)
                _FieldsParam = RestHelper.BuildParameter(ApiResources.Volume.Parameters.FieldList, EnumHelper.CleanEnumAndReturnAsLowercaseString(VolumeFields), ParameterType.QueryString);

            return GetResource<VolumeResponse>(_RequestResourceUrl, _FieldsParam);
        }

        public SearchResponse Search(string Query, SearchFieldList FieldList, RessourceType Resources = RessourceType.ALL, int Limit = 100, int Offset = 0)
        {
            List<Parameter> _Parameters = new List<Parameter>();

            if (Resources != RessourceType.ALL)
                _Parameters.Add(RestHelper.BuildParameter(ApiResources.Search.Parameters.Resources, EnumHelper.CleanEnumAndReturnAsLowercaseString(Resources), ParameterType.QueryString));

            _Parameters.Add(RestHelper.BuildParameter(ApiResources.Search.Parameters.Query, Query, ParameterType.QueryString));

            if (FieldList != null)
                _Parameters.Add(RestHelper.BuildParameter(ApiResources.Search.Parameters.FieldList, FieldList.GetFieldsAsQueryParameter(), ParameterType.QueryString));

            _Parameters.Add(RestHelper.BuildParameter(ApiResources.Search.Parameters.Limit, Limit, ParameterType.QueryString));

            _Parameters.Add(RestHelper.BuildParameter(ApiResources.Search.Parameters.Offset, Offset, ParameterType.QueryString));

            return GetResource<SearchResponse>(ApiResources.Search.Resource, _Parameters.ToArray());
        }

        private T GetResource<T>(string RequestResourceUrl, params Parameter[] FieldsParameter) where T : new()
        {
            RestClient _Client = RestHelper.CreateComicVineClient(fApiKey);

            IRestRequest _Request = new RestRequest(RequestResourceUrl, Method.GET);

            if (FieldsParameter != null)
                _Request.Parameters.AddRange(FieldsParameter.Where(w => w != null));

            _Request.AddParameter(ApiResources.Format, ApiResources.FormatXML, ParameterType.QueryString);

            IRestResponse<T> _Response = _Client.Execute<T>(_Request);

            if (_Response.ErrorException != null)
                throw _Response.ErrorException;

            return _Response.Data;
        }
    }
}