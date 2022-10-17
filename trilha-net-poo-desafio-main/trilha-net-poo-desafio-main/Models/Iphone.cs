namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero,string modelo, string imei,int memoria) : base(numero,modelo,imei,memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado no Iphone");
        }

        public override void ImprimirAplicativo()
        {
            Console.WriteLine($"Numero: {this.Numero} \n Modelo: {this.Modelo}\nIMEI: {this.Modelo}\nMemoria: {this.Memoria}");
        }
    }
}