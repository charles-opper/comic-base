namespace Thoorium.Comicvine.Objects
{
    public abstract class Response
    {
        public string Error { get; set; }
        public string Limit { get; set; }
        public string Number_Of_Page_Results { get; set; }
        public string Number_Of_Total_Results { get; set; }
        public string Offset { get; set; }
        public string Status_Code { get; set; }
        public string Version { get; set; }
    }
}