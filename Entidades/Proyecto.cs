using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioFaciens.Entidades
{
    public class Proyecto
    {
        public int ProyectoId { get; set; }
        public int DisenoId { get; set; }
        public string  UsuarioId { get; set; } 
        public bool Realizado { get; set; }
        public DateTime FechaGuardado { get; set; }

    }
}
