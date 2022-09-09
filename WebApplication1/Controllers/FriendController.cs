using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            List<ListOfFriend> friends = FriendServices.GetAll();
            return View(friends);
           
        }
        public IActionResult Details(int id)
        {
            ListOfFriend f = FriendServices.Get(id);
            return View(f);
        }

        public IActionResult List()
        {
            List<ListOfFriend> friends = FriendServices.GetAll();
            return View(friends);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ListOfFriend friend)
        {
            FriendServices.Add(friend);
            return RedirectToAction("List");
        }


        public IActionResult Delete(int id)
        {
            ListOfFriend f = FriendServices.Get(id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(ListOfFriend f)
        {
            FriendServices.Delete(f.Id);
            return RedirectToAction("List");
        }


        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(ListOfFriend f)
        {
            FriendServices.Update(f);
            return RedirectToAction("Index");
        }
    }
}
