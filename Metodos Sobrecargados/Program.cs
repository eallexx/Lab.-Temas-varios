namespace Metodos_Sobrecargados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SobreCarga varSobreCarga = new SobreCarga();
            varSobreCarga.ProbarMetodosSobreCargados();
            varSobreCarga.Cuadrado(8);
            Console.WriteLine("El cuadrado de {0}", varSobreCarga.Cuadrado(9));
        }
    }
}
