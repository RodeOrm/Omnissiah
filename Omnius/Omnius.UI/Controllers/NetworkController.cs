using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omnius.Domain.Abstract;
using Omnius.Domain.Entities;

namespace Omnius.UI.Controllers
{
    public class NetworkController : Controller
    {
        INetworkRepository repo;
        public NetworkController(INetworkRepository r)
        {
            repo = r;
        }

        public ActionResult List(int page = 1, string familyNameFilter = "")
        {

            int pageSize = 15;
            string currentFamilyName;

            return View();
        }
    }
}