using System.Collections.Specialized;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //private string imei;
        //private string modelo;
        //private string memoria;

        public string Numero { get; set; }
        public string IMEI { get; private set; }
        public string Modelo { get; private set; }
        public int Memoria { get; private set; }

        

        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            IMEI = imei;
            Modelo = modelo;
            Memoria = memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}