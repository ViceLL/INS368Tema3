using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PracticaWebApp
{
    /// <summary>
    /// Summary description for MyWebServices
    /// </summary>
    [WebService(Namespace = "http://practicasemana5INS368.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebServices : System.Web.Services.WebService
    {

        [WebMethod]
        public int CalcularAreaDeCuadrado(int x, int y)
        {
            return (x * y);
        }
        
        [WebMethod]
        public int CalcularAreaDeTriangulo(int x, int y)
        {
            return (x * y) / 2;
        }

        [WebMethod]
        public int CalcularAreaDeCirculo(double r)
        {
            double PI = 3.1415926535897932;
            return ((int)(PI * Math.Pow(r, 2)));
        }
    }
   
}
