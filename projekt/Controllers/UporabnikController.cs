using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using projekt.Models;

namespace projekt.Controllers
{
    public class UporabnikController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult RegistrirajDb(UporabnikModel model)
        {
            var db = new ContextDB();

            db.Uporabniki.Add(model);
            db.SaveChanges();

            return RedirectToAction("Login");
        }

        public IActionResult LoginDB(UporabnikModel model) 
        {
            try
            {
                var db = new ContextDB();
                var m = db.Uporabniki.Where(x => x.Ime == model.Ime && x.Priimek == model.Priimek && x.Geslo == model.Geslo).First();

                string idString = m.Id.ToString();

                var cookieOptions = new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(15),
                };

                Response.Cookies.Append("IdCookie", idString, cookieOptions);

                return Redirect("../Dokumenti/Dokumenti");
            }
            catch (Exception)
            {
                return RedirectToAction("Login");
            }

        }
    }
}
