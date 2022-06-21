namespace SOLID.DIP
{
    //Emailer é um low-level module, pois não depende de nenhuma classe
    public class Emailer : IMessageSender
    {
        public void SendMessage (IPerson owner, string v)
        {
            Console.WriteLine($"Simulating sending an email to {owner.EmailAddress}");
        }
    }
}