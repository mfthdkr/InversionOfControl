using System;

namespace InversionOfControl.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bl bl = new Bl(new OracleDal());
            bl.GetProducts().ForEach(x =>
            {
                Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
            });


            Console.ReadLine();
        }
    }
}
