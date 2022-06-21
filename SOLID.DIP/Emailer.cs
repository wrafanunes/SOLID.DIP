namespace SOLID.DIP
{
    internal class Emailer
    {
        internal void SendEmail (Person owner, string v)
        {
            Console.WriteLine($"Simulating sending an email to {owner.EmailAddress}");
        }
    }
}