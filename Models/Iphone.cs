namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
            base.Numero = numero;
            base.Modelo = modelo;
            base.IMEI = imei;
            base.Memoria = memoria;
        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine("Instalando App no iPhone: " + nomeApp);
        }
    }
}