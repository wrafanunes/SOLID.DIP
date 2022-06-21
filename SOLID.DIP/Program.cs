// See https://aka.ms/new-console-template for more information
//Program é um high-level module, que não depende mais de low-level modules como Person e Chore

/*Uma interface para Person foi criada, no entanto, pode-se observar que a classe Program ainda depende de Person
*(new Person), portanto, a aplicação ainda viola o DIP*/
/*Uma interface para Person foi criada, e a partir de agora a classe Factory é responsável por gerar novas instâncias
 * de Person, o que faz com que program não dependa mais da classe Person*/
using SOLID.DIP;

IPerson owner = Factory.CreatePerson();
owner.FirstName = "Wilson";
owner.LastName = "Nunes";
owner.EmailAddress = "wrsnunes@gmail.com";
owner.PhoneNumber = "(17) 99735-5859";

IChore chore = Factory.CreateChore();
chore.ChoreName = "Take out the trash";
chore.Owner = owner;

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();

Console.ReadLine();
