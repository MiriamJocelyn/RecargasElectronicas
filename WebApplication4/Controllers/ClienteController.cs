using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
  public class ClienteController : Controller
  {
    // GET: Cliente
    public ActionResult Index()
    {
      return View();
    }
    public JsonResult GetClientes()
    {
      List<Cliente> clientes = new Cliente().GetClientes();
      return Json(clientes, JsonRequestBehavior.AllowGet);
    }
  }
}