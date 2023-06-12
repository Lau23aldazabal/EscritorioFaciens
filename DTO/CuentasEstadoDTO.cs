using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioFaciens.DTO
{
    public class CuentasEstadoDTO
    { //para no utilizar el id el usurio
        public string Nombre { get; set; }
        public string Email { get; set; }
        public bool Bloqueado { get; set; }
        public DateTimeOffset? Fecha {get;set; }

    }
}
