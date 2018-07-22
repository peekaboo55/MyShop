using MyShop.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    public class BasketController : Controller
    {
        IBasketService basketService;

        public BasketController(IBasketService BasketService)
        {
            this.basketService = BasketService;
        }
        // GET: Basket
        public ActionResult Index()
        {
            var model = basketService.GetBasketItem(this.HttpContext);
            return View(model);
        }

        public ActionResult AddtoBasket (string Id)
        {
            basketService.AddtoBasket(this.HttpContext, Id);

            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromBasket(string Id)
        {
            basketService.RemoveFormBasket(this.HttpContext, Id);

            return RedirectToAction("Index");
        }

        public PartialViewResult BasketSummary()
        {
            var basketSummary = basketService.GetBasketSummary(this.HttpContext);

            return PartialView(basketSummary);
        }
    }
}