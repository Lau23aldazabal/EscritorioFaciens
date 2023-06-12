using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioFaciens.Entidades
{
    public class Estilo
    {
        public int EstiloId { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioIdCreador { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioIdModificacion { get; set; }

    }
}
