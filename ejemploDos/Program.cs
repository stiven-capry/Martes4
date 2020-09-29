using System;

namespace ejemploDos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONCESIONARIO");

            Console.WriteLine("Marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Serie");
            string serie = Console.ReadLine();
            Console.WriteLine("Modelo");
            short modelo = short.Parse(Console.ReadLine());
            Console.WriteLine("Placa");
            string placa = Console.ReadLine();
             Console.WriteLine("Remolque");
            string remolque = Console.ReadLine();

            //Instanciar la class vehiculo
            //var vehiculoUno = new Vehiculo()
        /*
            {
                Marca = marca,
                Serie = serie,
                Modelo = modelo,
                Placa = placa
            };
            

            //Console.WriteLine(vehiculoUno.Placa);
            Console.WriteLine(vehiculoUno.MarcaSerie);

            vehiculoUno.prender();
        */

        //instancia de herencia     
        var camionUno = new camion()
            {
                Marca = marca,
                Serie = serie,
                Modelo = modelo,
                Placa = placa,
                Remolque = remolque
            };
            
            Console.WriteLine($"{camionUno.MarcaSerie} con remolque {camionUno.Remolque}");
        }
    }
}
