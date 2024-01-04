using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            Nokia nokia = new Nokia("14998334276", "3310", "857438824351908", 16);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Snake");

            Console.WriteLine();

            Iphone iphone = new Iphone("14983987865", "X", "844573421098701", 64);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}
