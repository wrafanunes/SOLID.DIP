// See https://aka.ms/new-console-template for more information
using SOLID.DIP;

Person owner = new()
{
    FirstName = "Wilson",
    LastName = "Nunes",
    EmailAddress = "wrsnunes@gmail.com",
    PhoneNumber = "(17) 99735-5859"
};

Chore chore = new()
{
    ChoreName = "Take out the trash",
    Owner = owner
};

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();

Console.ReadLine();
