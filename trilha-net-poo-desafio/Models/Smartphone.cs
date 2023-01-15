using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public abstract void Ligar();

        public abstract void ReceberLigacao();
        
        public virtual void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instando o App {nomeApp}");
        }
    }
}