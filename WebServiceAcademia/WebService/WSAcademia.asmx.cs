using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Negocio;
using Entidades;

namespace WebService
{
    /// <summary>
    /// Descripción breve de Service1
    /// </summary>
    /// 
    //Namespace predeterminado
    /*[WebService(Namespace = "http://tempuri.org/")]*/
    [WebService(Namespace = "http://localhost/Service", Name = "WebServiceAcademia", Description = "Web service Academia")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSAcademia : System.Web.Services.WebService
    {

        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }

        private Usuario Entity
        {
            get;
            set;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public Usuario GetUser(int id)
        {
            return this.Logic.GetOne(id);
            
        }

        /*[WebMethod]
        public string GetName(int id)
        {
            Usuario user = new Usuario();
            user = this.Logic.GetOne(id);
            return user.Nombre;
        }*/
    }
}