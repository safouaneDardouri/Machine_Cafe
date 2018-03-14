using CoffeeMachine.core.SOLUTIONS.Coffee.Commande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CoffeeMachine.Controllers
{
    public class CommandeController : Controller
    {
        // GET: Commande
        [HttpPost]
        public JsonResult Index()
        {


            CommandeDAO commande = new CommandeDAO();
            var id = User.Identity.GetUserId();
          var commandes = commande.getByUser(id);
            return Json(commandes);
        }
        [HttpGet]
        public ActionResult Add()
        {
            CommandeDAO commande = new CommandeDAO();
            var id= User.Identity.GetUserId();
            ViewBag.commande = commande.getByUser(id);


            return View();
        }
        //[HttpPost]
        public bool Add(Commande cmd)
        {

            CommandeDAO commande = new CommandeDAO();
           var id = User.Identity.GetUserId();
           ViewBag.commande = commande.getByUser(id);
            var status = true;
            //Commande cmd = new Commande();
            //cmd.type = type;
            //cmd.qtsucre = qtsucre;
            //cmd.userId= User.Identity.GetUserId();
            //cmd.mugId = 0;
            //return View();

            try
            {
                commande.Add(cmd);
            }
            catch {
                status = false;
            }
            return status;
        }

        

    }
}