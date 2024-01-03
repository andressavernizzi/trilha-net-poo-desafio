using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Realizar os testes com as classes Nokia e Iphone
            Iphone iphone = new Iphone("123456789", "iPhone 12", "IMEI123", 64);
            Nokia nokia = new Nokia("987654321", "Nokia 7.2", "IMEI456", 32);

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Maps");
        }
    }
}
