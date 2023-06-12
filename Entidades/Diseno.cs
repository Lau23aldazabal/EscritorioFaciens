using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioFaciens.Entidades
{
    public class Diseno
    {
        public int DisenoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Materiales { get; set; }
        public string Dificultad { get; set; }
        public int EstiloId { get; set; }
        public int PrendaId { get; set; }
        public int TelaId { get; set; }
        public float? Valoracion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioIdCreador { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioIdModificacion { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<ImagenDiseno> ImagenDisenos { get; set; }
    }

    public enum DificultadEnum
    {
        Fácil,
        Intermedio,
        Avanzado
    }
}
