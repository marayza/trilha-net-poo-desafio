
namespace DesafioPOO.Models
{
    public class Samsumg : Smartphone
    {
        public Samsumg(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no modelo Samsumg.");
        }
    }
}