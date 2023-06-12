using EscritorioFaciens.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EscritorioFaciens.Entidades;
using System.IO;
using System.Windows.Forms;

namespace EscritorioFaciens
{
    public class Negocio
    {
        private static HttpClient _httpClient;
        public Negocio()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:44326/") };
        }

        //REGISTRO Y LOGIN: 
        public async Task<bool> Login(CredencialesUsuarioDTO credencialesUsuario)
        {
            var contenido = new StringContent(JsonConvert.SerializeObject(credencialesUsuario), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/cuentas/login", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    var resultadoJson = await respuesta.Content.ReadAsStringAsync();
                    Properties.Settings.Default.JwtToken = JsonConvert.DeserializeObject<ResultadoAutenticacionDTO>(resultadoJson).Token;
                    Properties.Settings.Default.Save();
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Registro(CredencialesUsuarioDTO credencialesUsuario)
        {
            var contenido = new StringContent(JsonConvert.SerializeObject(credencialesUsuario), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/cuentas/registro", contenido);

                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EsAdminAsync()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("api/cuentas/esAdmin");
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EsSuperAdminAsync()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("api/cuentas/SuperAdmin");
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<UsuarioAdministradorDTO>> ObtenerAdministradores()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync("api/cuentas/listAllUsers");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (List<UsuarioAdministradorDTO>)JsonConvert.DeserializeObject<List<UsuarioAdministradorDTO>>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //listEstadoCuentas
        public async Task<List<CuentasEstadoDTO>> ObtenerEstadoCuentas()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync("api/cuentas/listEstadoCuentas");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (List<CuentasEstadoDTO>)JsonConvert.DeserializeObject<List<CuentasEstadoDTO>>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //METODOS PARA LOS OBJETOS USUARIOADMINISTRADORDTO, SACA LOS NOMBRES DEL USUARIO, PASA EL NOMBRE A LA API Y QUITA O AÑADE EL CLAIM DE ADMINISTRADOR
        public async Task<bool> DarPrivilegiosAdministrativos(string username)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(username), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/cuentas/HacerAdmin", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync() ?? "Error al crear.", Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> QuitarPrivilegiosAdministrativos(string username)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                 HttpResponseMessage respuesta = await _httpClient.DeleteAsync($"api/cuentas/EliminarAdmin/{username}");
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync() ?? "Error al crear.", Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> ObtenerUsername(string id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/cuentas/userName?id={id}");
                if (response.IsSuccessStatusCode)
                {
                    var nombre = await response.Content.ReadAsStringAsync();
                    return nombre;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DesbloquearCuenta(string nombre)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpContent contenido = new StringContent(JsonConvert.SerializeObject(nombre), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PutAsync($"api/cuentas/QuitarBloqueo", contenido);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> BloquearCuenta(CuentasEstadoDTO cuentasEstadoDTO) //MODIFICAR
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(cuentasEstadoDTO), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await _httpClient.PutAsync($"api/cuentas/CrearBloqueo", contenido);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //FALTA CREAR Y RETIRAR BLOQUEO DE CUENTA 
        //
        /// ESTILOS
        public async Task<List<Estilo>> ObtenerEstilos()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync("api/estilo/listAll");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (List<Estilo>)JsonConvert.DeserializeObject<List<Estilo>>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Estilo> ObtenerEstilo(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/estilo/getEstilo/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (Estilo)JsonConvert.DeserializeObject<Estilo>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> ObteneNombrerEstilo(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/estilo/getNombreEstilo/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var nombre = await response.Content.ReadAsStringAsync();
                    return nombre;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CrearEstilo(Estilo estilo)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(estilo), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/estilo/AddNewOne", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync() ?? "Error al crear.", Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> ModificarEstilo(Estilo estilo)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(estilo), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage message = await _httpClient.PutAsync($"api/estilo/Modify/{estilo.EstiloId}", contenido);
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await message.Content.ReadAsStringAsync() ?? "Error al modificar.", Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EliminarEstilo(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage respuesta = await _httpClient.DeleteAsync($"api/estilo/Delete/{id}");
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync() ?? "Error al borrar.", Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// TELAS
        /// </summary>
        /// <returns></returns>
        public async Task<List<Tela>> ObtenerTelas()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync("api/tela/listAll");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    List<Tela> objects = JsonConvert.DeserializeObject<List<Tela>>(json);
                    return objects;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Tela> ObtenerTela(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/tela/getTela/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (Tela)JsonConvert.DeserializeObject<Tela>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> ObteneNombrerTela(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/tela/getNombreTela/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var nombre = await response.Content.ReadAsStringAsync();
                    return nombre;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CrearTela(Tela tela)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(tela), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/tela/AddNewOne", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {

                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //MODIFICAR Y ELIMINAR:
        public async Task<bool> ModificarTela(Tela tela)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(tela), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage message = await _httpClient.PutAsync($"api/tela/Modify/{tela.TelaId}", contenido);
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await message.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EliminarTela(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage respuesta = await _httpClient.DeleteAsync($"api/tela/Delete/{id}");
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// PRENDA
        /// </summary>
        /// <returns></returns>
        public async Task<List<Prenda>> ObtenerPrendas()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync("api/prenda/listAll");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    List<Prenda> objects = JsonConvert.DeserializeObject<List<Prenda>>(json);
                    return objects;

                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Prenda> ObtenerPrenda(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/prenda/getPrenda/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (Prenda)JsonConvert.DeserializeObject<Prenda>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> ObteneNombrerPrenda(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/prenda/getNombrePrenda/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var nombre = await response.Content.ReadAsStringAsync();
                    return nombre;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CrearPrenda(Prenda prenda)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(prenda), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/prenda/AddNewOne", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //MODIFICAR Y ELIMINAR:
        public async Task<bool> ModificarPrenda(Prenda prenda)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(prenda), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage message = await _httpClient.PutAsync($"api/prenda/Modify/{prenda.PrendaId}", contenido);
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await message.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EliminarPrenda(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage respuesta = await _httpClient.DeleteAsync($"api/prenda/Delete/{id}");
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// DISEÑOS
        /// </summary>
        /// <returns></returns>
        public async Task<List<Diseno>> ObtenerDisenos()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync("api/diseno/listAll");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    List<Diseno> objects = JsonConvert.DeserializeObject<List<Diseno>>(json);
                    return objects;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Diseno> ObtenerDiseno(int id) // quitar que eso sea solo los adminitradores. 
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"/api/diseno/getDiseno/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (Diseno)JsonConvert.DeserializeObject<Diseno>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> CrearDiseno(Diseno diseno) // que devuelv EL INT
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(diseno), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/diseno/AddNewOne", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    var cod = int.Parse(await respuesta.Content.ReadAsStringAsync());
                    return cod; //para que devuelva el codigo del objeto creado y se almacene correctamente la lista de imagenes asociadas a este.
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //MODIFICAR Y ELIMINAR:
        public async Task<bool> ModificarDiseno(Diseno diseno)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(diseno), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage message = await _httpClient.PutAsync($"api/diseno/Modify/{diseno.DisenoId}", contenido);
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await message.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EliminarDiseno(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage respuesta = await _httpClient.DeleteAsync($"api/diseno/Delete/{id}");
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> ObteneNombrerDiseno(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/diseno/getNombreDiseno/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var nombre = await response.Content.ReadAsStringAsync();
                    return nombre;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //DISENO IMAGENES: APARTADO CREACION, ELIMINACION MODIFICACION Y OBTENCIÓN DE LAS IMAGENES:

        public async Task<List<ImagenDiseno>> ObtenerImagenes(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/imagendiseno/obtenerImagenes/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (List<ImagenDiseno>)JsonConvert.DeserializeObject<List<ImagenDiseno>>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ImagenDiseno> ObtenerImagen(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/imagendiseno/obtenerImagen/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (ImagenDiseno)JsonConvert.DeserializeObject<ImagenDiseno>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> CrearImagenDiseno(ImagenDiseno imagenDiseno)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(imagenDiseno), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/imagendiseno/crearImagenPrueba", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EliminarImagenDiseno(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage respuesta = await _httpClient.DeleteAsync($"api/imagendiseno/Delete/{id}");
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ModificarImagenDiseno(ImagenDiseno imagenDiseno)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(imagenDiseno), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage message = await _httpClient.PutAsync("api/imagendiseno/modificarImagenPrueba", contenido);
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await message.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //PARA LOS COMENTARIOS:
        public async Task<List<Comentario>> ObtenerComentarios(int disenoId)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/diseno/{disenoId}/comentarios/getDesingComments");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (List<Comentario>)JsonConvert.DeserializeObject<List<Comentario>>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Comentario> ObtenerComentario(int id, int disenoId)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/diseno/{disenoId}/comentarios/getComment/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (Comentario)JsonConvert.DeserializeObject<Comentario>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CrearComentario(Comentario comentario)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(comentario), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync($"api/diseno/{comentario.DisenoId}/comentarios/addComment", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ModificarComentario(Comentario comentario)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(comentario), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage message = await _httpClient.PutAsync($"api/diseno/{comentario.DisenoId}/comentarios/Modify/{comentario.ComentarioId}", contenido);
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await message.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> EliminarComentario(int id, Diseno diseno)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage respuesta = await _httpClient.DeleteAsync($"api/diseno/{diseno.DisenoId}/comentarios/Delete/{id}"); //CAMBIAR LA URL
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Proyecto>> ObtenerProyectos()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/proyecto/listarProyectosUsuario");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (List<Proyecto>)JsonConvert.DeserializeObject<List<Proyecto>>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Proyecto> ObtenerProyecto(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                var response = await _httpClient.GetAsync($"api/proyecto/getProyecto/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return (Proyecto)JsonConvert.DeserializeObject<Proyecto>(json);
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await response.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CrearProyecto(Proyecto proyecto)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(proyecto), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsync("api/proyecto/AddNewOne", contenido);
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync() ?? "Error al crear.", Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> EliminarProyecto(int id)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            try
            {
                HttpResponseMessage respuesta = await _httpClient.DeleteAsync($"api/proyecto/Delete/{id}");
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await respuesta.Content.ReadAsStringAsync() ?? "Error al borrar.", Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> ModificarProyecto(Proyecto proyecto)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.JwtToken);
            var contenido = new StringContent(JsonConvert.SerializeObject(proyecto), System.Text.Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage message = await _httpClient.PutAsync($"api/proyecto/Modificar/{proyecto.ProyectoId}", contenido);
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception(String.Concat(Environment.NewLine, await message.Content.ReadAsStringAsync(), Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
