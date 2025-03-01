namespace EmphasisGraylogConsole.Senders
{
    public interface IGraylogSender
    {
        void SendAsync(string jsonMessage);
        string CreateMessage(object[] parameters);
    }
}
