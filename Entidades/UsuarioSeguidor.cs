using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscritorioFaciens.Entidades
{
    public class UsuarioSeguidor
    {
        public int RegistroId { get; set; }
        public string UsuarioSeguidorId { get; set; }
        public string UsuarioSeguidoId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
