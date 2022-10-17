namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero,string modelo, string imei,int memoria) : base(numero,modelo,imei,memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado no Nokia");
        }

        public override void ImprimirAplicativo()
        {
            Console.WriteLine($"Numero: {this.Numero} \n Modelo: {this.Modelo}\nIMEI: {this.Modelo}\nMemoria: {this.Memoria}");
        }
    }
}