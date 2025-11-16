using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PCsite.Models;

namespace PCsite.Controllers
{
    public class SoftwareController : Controller
    {
        public IActionResult Index(string? view)
        {
            // Se não foi especificada nenhuma partial, mostra a view principal normal
            if (string.IsNullOrEmpty(view))
                return View();

            // Se houver um parâmetro, envia o nome da partial para a ViewData
            ViewData["PartialName"] = view;
            return View();
        }

        // Estas actions devolvem as partials via AJAX
        public IActionResult Os() => PartialView("PartialView/Osview");
        public IActionResult BRW() => PartialView("PartialView/BRWview");
        public IActionResult TX() => PartialView("PartialView/TXview");
        public IActionResult DB() => PartialView("PartialView/DBview");
        public IActionResult PASS() => PartialView("PartialView/PASSview");
        public IActionResult AV() => PartialView("PartialView/AVview");
        public IActionResult FW() => PartialView("PartialView/FWview");
        public IActionResult CLOUD() => PartialView("PartialView/CLOUDview");
        public IActionResult PKG() => PartialView("PartialView/PKGview");
        public IActionResult TASK() => PartialView("PartialView/TASKview");
        public IActionResult TERM() => PartialView("PartialView/TERMview");
        public IActionResult VM() => PartialView("PartialView/VMview");
        public IActionResult VPN() => PartialView("PartialView/VPNview");
        public IActionResult ARCH() => PartialView("PartialView/ARCHview");
        public IActionResult CFG() => PartialView("PartialView/CFGview");


    }
}
