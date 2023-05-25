namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
            base.Numero = numero;
            base.Modelo = modelo;
            base.IMEI = imei;
            base.Memoria = memoria;
        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine("Instalando App no Nokia: " + nomeApp);
        }
    }
}