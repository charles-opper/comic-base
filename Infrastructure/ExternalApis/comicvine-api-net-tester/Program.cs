using Thoorium.Comicvine.Api;
using Thoorium.Comicvine.Enums;
using Thoorium.Comicvine.Objects;

namespace comicvine_api_net_tester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var comic = new Comicvine("837a750249a6c3236b0b1d85a93a45aac22ec3fc");//Put your api key here

            var charactersearchfieldlist = new SearchFieldList
            {
                CharacterFields = CharacterFields.API_DETAIL_URL
            };

            var search = comic.Search("Doom", charactersearchfieldlist, RessourceType.CHARACTER);
            var charapiid = search.Results.Characters[0].GetCharacterApiId();

            var character = comic.GetCharacter(charapiid);//DOOM
            var issue = comic.GetIssue("4000-487843");//Secret Wars 2015 #1
        }
    }
}