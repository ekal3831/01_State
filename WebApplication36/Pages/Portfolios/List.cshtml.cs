using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebApplication36.Models;
using WebApplication36.Services;

namespace WebApplication36.Pages.Portfolios
{
    public class ListModel : PageModel
    {
        private readonly PortfolioserviceJsonFile _service;
        
        // �������� �Ű������� ����(�������丮) Ŭ���� ����
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
