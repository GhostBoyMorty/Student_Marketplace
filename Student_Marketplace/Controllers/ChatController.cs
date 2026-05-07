using Microsoft.AspNetCore.Mvc;
using Student_Marketplace.Models;
using System;

namespace Student_Marketplace.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {

            var model = new ChatsM();
            return View(model);
           
        }
        public IActionResult ChatList()
        {

        



            return View();


        }
       
    }
}
