﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EirlElRojo.Modelo
{
    public struct Rutas
    {

        public string Chofer { get; set; }
        public string Compania { get; set; }
        public List<localizacion> Estaciones { get; set; }
        public Guid Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }


        public override string ToString()
        {
            return $"Ruta: {Chofer}-{Compania}--{FechaInicio}/{FechaFin}";
        }
    }
}
