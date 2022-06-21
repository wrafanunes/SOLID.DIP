namespace SOLID.DIP
{
    //Emailer é um low-level module, pois não depende de nenhuma classe
    internal class Emailer
    {
        internal void SendEmail (IPerson owner, string v)
        {
            Console.WriteLine($"Simulating sending an email to {owner.EmailAddress}");
        }
    }
}