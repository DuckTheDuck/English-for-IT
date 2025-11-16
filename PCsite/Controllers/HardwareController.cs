using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PCsite.Models;

namespace PCsite.Controllers
{
    public class HardwareController : Controller
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
        public IActionResult CPU() => PartialView("PartialView/CPUview");
        public IActionResult Motherboard() => PartialView("PartialView/Motherboardview");
        public IActionResult GPU() => PartialView("PartialView/GPUview");
        public IActionResult PSU() => PartialView("PartialView/PSUview");
        public IActionResult RAM() => PartialView("PartialView/RAMview");
        public IActionResult HardDrive() => PartialView("PartialView/HardDriveview");
        public IActionResult Case() => PartialView("PartialView/Caseview");
        public IActionResult Pc() => PartialView("PartialView/Pcview");
    }
}
