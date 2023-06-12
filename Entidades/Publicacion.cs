using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioFaciens.Entidades
{
    public class Publicacion
    {
        public int PublicacionId { get; set; }
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Texto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public List<AdjuntoPublicacion> AdjuntoPublicaciones { get; set; }

    }
}
