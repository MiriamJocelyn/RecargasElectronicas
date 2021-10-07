using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace El_Hivan.Models
{
    public class Response
    {
        public object AllOk()
        {
            ResponseProperties cn = new ResponseProperties();

            cn.MethodSuccess = true;
            cn.Message = "Datos Insertados Correctamente";
            cn.Status = 200;
            return cn;
        }

        public object WentBad()
        {
            ResponseProperties cn = new ResponseProperties();

            cn.MethodSuccess = false;
            cn.Message = "Datos No Insertados";
            cn.Status = 900;

            return cn;
        }
        public object RepeatedData()
        {
            ResponseProperties cn = new ResponseProperties();

            cn.MethodSuccess = false;
            cn.Message = "Datos No Insertados, el registro ya fue insertado anteriormente";
            cn.Status = 800;

            return cn;
        }
     
        public ServerErrorProperties ServerError(string url, string mensaje = "")
        {
            ServerErrorProperties cn = new ServerErrorProperties();

            cn.IsServerError = true;
            cn.UrlError = url;
            cn.Mensaje = mensaje;

            return cn;
        }
    }

    public class ResponseProperties
    {
        public bool MethodSuccess { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class ServerErrorProperties
    {
        public bool IsServerError { get; set; }
        public string UrlError { get; set; }
        public string Mensaje { get; set; }
    }
}