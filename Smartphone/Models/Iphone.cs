namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instando o {nomeApp} no disposivo IOS");
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