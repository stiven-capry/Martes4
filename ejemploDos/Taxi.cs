using System;

namespace ejemploDos
{
    class Taxi : Vehiculo
    {
        //pripiedad
        private short Banderazo {get;set;}

        

        public short valorPagar(short valorRecorrido)
        {
        short totalPagar = Banderazo;

        totalPagar += valorRecorrido;

        return totalPagar;
        }   
    }
}