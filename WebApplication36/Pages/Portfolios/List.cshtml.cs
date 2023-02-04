using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebApplication36.Models;
using WebApplication36.Services;

namespace WebApplication36.Pages.Portfolios
{
    public class ListModel : PageModel
    {
        private readonly PortfolioserviceJsonFile _service;
        
        // 생성자의 매개변수로 서비스(리포지토리) 클래스 주입
        public ListModel(PortfolioserviceJsonFile service)
        {
            this._service = service;
        }

        public IEnumerable<Portfolio> Portfolios { get; private set; }

        public void OnGet()
        {
            Portfolios = _service.GetPortfolios();
        }
    }
}
