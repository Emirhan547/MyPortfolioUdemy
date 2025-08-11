using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DataAccessLayer.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = portfolioContext.Messages.ToList();
            return View(values);
        }
        public IActionResult ChaneIsReadToTrue(int id)
        {
            var value = portfolioContext.Messages.Find(id);
            value.IsRead = true;
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChaneIsReadToFalse(int id)
        {
            var value = portfolioContext.Messages.Find(id);
            value.IsRead = false;
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult DeleteMessage(int id)
        { 
            var value =portfolioContext.Messages.Find(id);
            portfolioContext.Messages.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("Inbox");

        }
        public IActionResult MessageDetails(int id)
        {
            var value = portfolioContext.Messages.Find(id);
            return View(value);
        }
    }
}
