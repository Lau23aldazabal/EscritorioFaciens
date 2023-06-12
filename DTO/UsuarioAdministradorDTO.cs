using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioFaciens.DTO
{
    public class UsuarioAdministradorDTO //PARA QUITAR O AÑADIR PERMISOS ADMINISTRATIVOS SIN USAR EL ID DE LOS USUARIOS.
    {
            public String username { get; set; }
            public bool esAdmin { get; set; }
        
    }
}
