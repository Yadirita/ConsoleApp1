using ConsoleApp1.Jerarquia;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hola mundito");

            Vehiculo MiCamion = new Vehiculo();
            MiCamion.setIdentificacion("A1");
            MiCamion.setNumeroDeMinutos(200);
            Console.WriteLine("El camión me debe: " + MiCamion.dameImporte());


            Vehiculo MiFurgoneta = new Vehiculo();
            MiFurgoneta.setIdentificacion("F1");
            MiFurgoneta.setNumeroDeMinutos(100);
            Console.WriteLine("La furgoneta me debe: " + MiFurgoneta.dameImporte());

        }
    }
}
