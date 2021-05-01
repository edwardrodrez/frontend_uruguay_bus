namespace UruguayBus.Controllers
{
    internal class HttpStringContent
    {
        private string json;
        private object utf8;
        private string v;

        public HttpStringContent(string json, object utf8, string v)
        {
            this.json = json;
            this.utf8 = utf8;
            this.v = v;
        }
    }
}