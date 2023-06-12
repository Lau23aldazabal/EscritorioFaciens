using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioFaciens.Entidades
{
    public class ImagenDiseno
    {
        public int ImagenDisenoId { get; set; }
        public int DisenoId { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioIdCreador { get; set; }
        public string UsuarioIdModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
