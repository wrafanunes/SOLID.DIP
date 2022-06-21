namespace SOLID.DIP
{
    //Logger é um low-level module, pois não depende de nenhuma classe
    internal class Logger
    {
        internal void Log (string v)
        {
            Console.WriteLine ($"Write to Console: {v}");
        }
    }
}