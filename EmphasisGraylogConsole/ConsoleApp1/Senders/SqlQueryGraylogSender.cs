using EmphasisGraylogConsole.MessageFactory;
using System.Net.Http;
using System.Text;

namespace EmphasisGraylogConsole.Senders
{
    public class SqlQueryGraylogSender : IGraylogSender
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string _url;
        private readonly IGraylogMessageFactory _messageFactory;

        public SqlQueryGraylogSender(string url, IGraylogMessageFactory messageFactory)
        {
            _url = url;
            _messageFactory = messageFactory;
        }

        public async void SendAsync(string jsonMessage)
        {
            var content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");
            await httpClient.PostAsync(_url, content);
        }

        public string CreateMessage(object[] parameters)
        {
            return _messageFactory.CreateMessage(parameters);
        }
    }
}
