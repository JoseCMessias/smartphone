using System.Reflection;
using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instando o {nomeApp} no dispositivo Android");
        }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando para o número {Numero}");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação do número: {Numero}");
        }
    }
}