using DesafioPOO.Models;
using System;

namespace DesaioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone("81984550432", "iphone 11", "121212", 120);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine("");

            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia("81985345525", "nokia C20", "131313", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Facebook");
        }
    }
}

