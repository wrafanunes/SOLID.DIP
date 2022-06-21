using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class Chore
    {
        private Person? _owner;
        public string? ChoreName { get; set; }
        public Person Owner
        {
            get => _owner ??= new Person();
            set => _owner = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        internal void CompleteChore ()
        {
            //Chore é um high-level module, que depende De Logger e Emailer
            IsComplete = true;
            Logger logger = new();
            logger.Log($"Completed {ChoreName}");

            Emailer emailer = new();
            emailer.SendEmail(Owner, $"The chore {ChoreName} is complete");
        }

        internal void PerformedWork (double v)
        {
            HoursWorked += v;
            Logger logger = new();
            logger.Log($"Performed work on {ChoreName}");
        }
    }
}
