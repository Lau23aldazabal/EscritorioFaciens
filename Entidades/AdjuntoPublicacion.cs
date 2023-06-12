using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioFaciens.Entidades
{
    public class AdjuntoPublicacion
    {
        public int AdjuntoPublicacionId { get; set; }
        public int PublicacionId { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }

    }
}
