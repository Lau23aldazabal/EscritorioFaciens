using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioFaciens.Entidades
{
    public class Prenda
    {
        public int PrendaId { get; set; }
        public string  Nombre { get; set; }
        public DateTime FechaCreacion { get; set; } 
        public string UsuarioIdCreador { get; set; }  
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioIdModificacion { get; set; }

    }
}
