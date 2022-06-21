namespace SOLID.DIP
{
    internal class Logger
    {
        internal void Log (string v)
        {
            Console.WriteLine ($"Write to Console: {v}");
        }
    }
}