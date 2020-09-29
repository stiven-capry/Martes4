 using System;

namespace ejemploDos
{
    class Vehiculo
    {
        //Propiedades ( modificador de acceso privado o publico)

        /*Modificador de acceso 
        public: la propiedad o metodo se pueden utilizar en cualquier parte 
        private: la pripiedad o metodo solo se puede utilizar en la misma clase
        protected: la pripiedad o metodo solo se puede utilizar en las clases  que heredan de la class padre donde estan las propiedades o metodos
        
        */
        
        public string Marca { get; set; }

        public string Serie { get; set; }

        //Ej concatenar propiedades (Marca y Serie)
        public string MarcaSerie 
        { 
            get 
            {
                return $"Vehiculo tipo {Marca} serie {Serie}";
            }
        }

        short modelo;
        public short Modelo { 
            get
            {
                return modelo;
            }
            set
            {
                if (value > 2017 && value < 2022)
                {
                    modelo = value;
                }
                else
                {
                    Console.WriteLine("Modelo no valido");
                }                
            }
        }


        string placa;
        public string Placa {
            get
            {
                return placa;
            }
            set
            {
                if (value.Length == 6)
                {
                    placa = value;
                }
                else
                {
                    Console.WriteLine("La placa debe ser de 6 digitos");
                }
            }
        }

        protected string Ruta { get; set; }

        //Metodos
        public void prender()
        {
            Console.WriteLine("El vehiculo esta prendiendo");        }
    }
}