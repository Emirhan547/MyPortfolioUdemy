using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DataAccessLayer.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
    
    }

