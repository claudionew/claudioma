using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EirlElRojo.Modelo
{
    public struct Reserva
    {
        private localizacion destino;
        private localizacion salida;
        private DateTime fecha;
         
   
    public localizacion Destino
    {
        get; set;
    }

    public localizacion Salida
    {
        get; set;
    }

    public DateTime Fecha
    {
        get; set;
    }

    }
}
