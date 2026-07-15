namespace IUIS.Interfaces
{
    public interface INotification
    {
        void Send(string recipientId, string message);
        void Broadcast(string message);
    }
}