using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class Chore : IChore
    {
        ILogger _logger;
        IMessageSender _messageSender;

        private IPerson? _owner;
        public string? ChoreName { get; set; }
        public IPerson Owner
        {
            get => _owner ??= new Person();
            set => _owner = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }
        /*as classes de Logger e Emailer são chamadas no construtor usando suas respectivas interfaces,
         * dessa forma, não é preciso criar novas instâncias usando new()*/
        public Chore (ILogger logger, IMessageSender sender)
        {
            _logger = logger;
            _messageSender = sender;
        }

        public void CompleteChore ()
        {
            //Chore é um high-level module, que depende De Logger e Emailer
            IsComplete = true;
            _logger.Log($"Completed {ChoreName}");

            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete");
        }

        public void PerformedWork (double v)
        {
            HoursWorked += v;
            _logger.Log($"Performed work on {ChoreName}");
        }
    }
}
