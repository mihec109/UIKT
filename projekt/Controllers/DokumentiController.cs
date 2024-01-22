using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projekt.Models;

namespace projekt.Controllers
{
    public class DokumentiController : Controller
    {
        public IActionResult Dokumenti()
        {
            return View();
        }

        public IActionResult Upesno()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFiles(IFormFile obrazec, IFormFile pravnaPodlaga, IFormFile dodato)
        {
            var dokumenti = new DokumentiModel();

            var _context = new ContextDB();

            using (var memoryStream = new MemoryStream())
            {
                await obrazec.CopyToAsync(memoryStream);
                dokumenti.obrazec = memoryStream.ToArray();
            }

            using (var memoryStream = new MemoryStream())
            {
                await pravnaPodlaga.CopyToAsync(memoryStream);
                dokumenti.pravnaPodlaga = memoryStream.ToArray();
            }

            using (var memoryStream = new MemoryStream())
            {
                await dodato.CopyToAsync(memoryStream);
                dokumenti.dodato = memoryStream.ToArray();
            }

            Request.Cookies.TryGetValue("IdCookie", out string idString);

            dokumenti.Uporabnik = int.Parse(idString);

            _context.Add(dokumenti);
            await _context.SaveChangesAsync();

            // Redirect to a confirmation page, etc.
            return RedirectToAction("Upesno");
        }

    }
}
