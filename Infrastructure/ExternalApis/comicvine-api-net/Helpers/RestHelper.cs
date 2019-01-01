using RestSharp;

namespace Thoorium.Comicvine.Helpers
{
    public static class RestHelper
    {
        private static string COMICVINE_API_URL = "http://www.comicvine.com/api/";

        public static RestClient CreateComicVineClient(string ComicVineApiKey)
        {
            RestClient _Client = new RestClient(COMICVINE_API_URL);
            _Client.AddDefaultParameter(new Parameter() { Name = "api_key", Type = ParameterType.QueryString, Value = ComicVineApiKey });

            return _Client;
        }

        public static Parameter BuildParameter(string Name, object Value, ParameterType Type)
        {
            return new Parameter
            {
                Name = Name,
                Value = Value,
                Type = Type
            };
        }
    }
}