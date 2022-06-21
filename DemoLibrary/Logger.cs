namespace SOLID.DIP
{
    //Logger é um low-level module, pois não depende de nenhuma classe
    public class Logger : ILogger
    {
        public void Log (string v)
        {
            Console.WriteLine($"Write to Console: {v}");
        }
    }
}