namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp) =>
            Console.WriteLine($"Instalando o app {nomeApp} da Apple Store");
    }
}