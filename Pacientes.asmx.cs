using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using LogicaNegocio.DTO;
using LogicaNegocio.Sesion;
using Newtonsoft.Json; 
namespace Lab14_AD
{
    /// <summary>
    /// Summary description for Pacientes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Pacientes : System.Web.Services.WebService
    {

        [WebMethod]
        public void InsertarUsuario(PacienteDTO PacienteDto)
        {
            GestorClinica gestorUsuario = new GestorClinica(Properties.Settings.Default.StringConnection);
            gestorUsuario.InsertarPaciente(PacienteDto);
        }       
        [WebMethod]
        public string ListarUsuarios(string Nombre)
        {
            GestorClinica gestorUsuario = new GestorClinica(Properties.Settings.Default.StringConnection);
            return JsonConvert.SerializeObject(gestorUsuario.ListaPacientes(Nombre));
        }

        [WebMethod]
        public string ListaSucesos()
        {
            GestorClinica gestorUsuario = new GestorClinica(Properties.Settings.Default.StringConnection);
            return JsonConvert.SerializeObject(gestorUsuario.ListarSuceso());
        }
    }
}
