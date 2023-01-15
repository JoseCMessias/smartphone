using DesafioPOO.Models;
using System;

namespace DesaioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone nokia = new Nokia("81985345525", "nokia C20", "131313", 64);
            Smartphone iphone = new Iphone("81984550432", "iphone 11", "121212", 120);
            
            Console.WriteLine("========== Smartphone Iphone ==========");
            iphone.InstalarAplicativo("WhatsApp");
            nokia.Ligar();

            Console.WriteLine("=======================================");

            Console.WriteLine("========== Smartphone Nokia ==========");
            nokia.InstalarAplicativo("WhatsApp");
            iphone.ReceberLigacao();    
        }
    }
}

