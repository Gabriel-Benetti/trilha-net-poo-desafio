

namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(String nomeApp)
        {
            Console.WriteLine($"Instalando o App {nomeApp} no Iphone");
        }
    }
}