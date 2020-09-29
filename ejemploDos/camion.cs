using System;

namespace ejemploDos
{
    class camion : Vehiculo
    {
        string tipoR;    
        public string Remolque 
        {
            get{ return tipoR; }  
            set{
                //string tipoRemolque = value;
                switch (value.ToLower())
                {
                    case "CamaBaja":
                        tipoR = value;
                        break;
                    case "Contenedor":
                        tipoR = value;
                        break;
                    case "Sisterna":
                        tipoR = value;
                        break;
                    case "Plancho":
                        tipoR = value;
                        break;
                    case "Ninera":
                        tipoR = value;
                        break;
                    default: 
                        Console.WriteLine($"Remolque no existe, por favor verificar");
                        break;
                }
            
            }
        }

        public void mostrarDatos()
        {
            Console.WriteLine(Serie);
        }

        public string listaRuta()
        {
            return Ruta.ToString();
        }

    }
}