using Microsoft.AspNetCore.Http;

namespace EscritorioFaciens
{
    public class AdjuntoPublicacionDTO
    {
        public int AdjuntoPublicacionId { get; set; }
        public int PublicacionId { get; set; }
        public string Nombre { get; set; }
        public IFormFile Foto { get; set; }
    }
}
