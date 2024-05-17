using LuxGamingShop.Models;
using LuxGamingShop.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace LuxGamingShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {

            var contact = new ContactUs
            {
                Email = "info@example.com",
                Phone = "+123456789",
                Adress = "123 Main Street, City, Countryyyyyyyyyyyyy"
            };

            ContactIndexVM vm = new ContactIndexVM();

            vm.ContactUs = contact;
            return View(contact);
        }
    }
}
