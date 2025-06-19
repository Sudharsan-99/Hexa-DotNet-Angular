using ClientDirectory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ClientDirectory.Controllers
{
    [Route("Client")]
    public class ClientController : Controller
    {
        static List<ClientInfo> clients = new List<ClientInfo>();

        [Route("ShowAll")]
        public IActionResult ShowAllClientDetails()
        {
            return View("ShowAllClientDetails", clients);
        }

        [Route("GetById/{id}")]
        public IActionResult GetDetailsByClientId(int id)
        {
            var client = clients.FirstOrDefault(c => c.ClientId == id);
            return View("ClientDetails", client);
        }

        [Route("GetByName/{name}")]
        public IActionResult GetDetailsByCompanyName(string name)
        {
            var client = clients.FirstOrDefault(c => c.CompanyName.ToLower() == name.ToLower());
            return View("ClientDetails", client);
        }

        [Route("GetByEmail/{email}")]
        public IActionResult GetDetailsByEmail(string email)
        {
            var client = clients.FirstOrDefault(c => c.Email.ToLower() == email.ToLower());
            return View("ClientDetails", client);
        }

        [Route("GetByCategory/{category}")]
        public IActionResult GetDetailsByCategory(string category)
        {
            var result = clients.Where(c => c.Category.ToLower() == category.ToLower()).ToList();
            return View("ShowAllClientDetails", result);
        }

        [Route("GetByStandard/{standard}")]
        public IActionResult GetDetailsByStandard(string standard)
        {
            var result = clients.Where(c => c.Standard.ToLower() == standard.ToLower()).ToList();
            return View("ShowAllClientDetails", result);
        }

        [Route("AddClient")]
        public IActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        [Route("AddClient")]
        public IActionResult AddClient(ClientInfo clientInfo)
        {
            clientInfo.ClientId = clients.Count > 0 ? clients.Max(c => c.ClientId) + 1 : 1;
            clients.Add(clientInfo);
            return RedirectToAction("ShowAllClientDetails");
        }
    }
}
}
