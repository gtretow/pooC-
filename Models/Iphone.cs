namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                Console.WriteLine($"Instalando {nomeApp} no Iphone");
            }
            catch (System.Exception)
            {

                throw new NotImplementedException();
            }
        }

    }
}