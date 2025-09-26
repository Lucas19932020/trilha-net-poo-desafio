namespace DesafioPOO.Models
{
    //Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        //Sobrescrevendo o método "InstalarAplicativo" para o Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no seu Nokia");
        }
    }
}