using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioFaciens
{
    public class FuncionesGenerales 
    {
        //PARA CARGAR LAS IMAGENES PROPORCIONADAS POR LA API
        public static Image CargarImagen(string url)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream = response.GetResponseStream();
            Bitmap bmp = new Bitmap(responseStream);
            return bmp;
        }
    }
}
