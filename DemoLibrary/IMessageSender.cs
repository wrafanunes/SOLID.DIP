namespace SOLID.DIP
{
    public interface IMessageSender
    {
        void SendMessage (IPerson owner, string v);
    }
}