// See https://aka.ms/new-console-template for more information
using SOLID.DIP;
//Program é um high-level module, que depende de Person e Chore

/*Uma interface para Person foi criada, no entanto, pode-se observar que a classe Program ainda depende de Person
*(new Person), portanto, a aplicação ainda viola o DIP*/
IPerson owner = new Person
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
