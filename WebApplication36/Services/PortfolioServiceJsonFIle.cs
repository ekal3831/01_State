using Microsoft.AspNetCore.Hosting;
using System.Collections;
using System.Collections.Generic; // IEnumnerable
using System.IO; //  File
using System.Text.Json; //  JsonSerializer
using WebApplication36.Models; //  Portfolio

namespace WebApplication36.Services
{
    public class PortfolioserviceJsonFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PortfolioserviceJsonFile(IWebHostEnvironment webHostEnvironment) 
        {
            this._webHostEnvironment = webHostEnvironment;
        }

        // prop tabtab으로 생성
        //WebRootPath : wwwroot 물리적 경로 알려줌 
        private string JsonFileName
    {
        get
        {
            //return _webHostEnvironment.WebRootPath + "\\Portfolios" + "\\portfolios.json";
            return Path.Combine(_webHostEnvironment.WebRootPath, "Portfolios", "portfolios.json");


        }
    }   
        
        public IEnumerable<Portfolio> GetPortfolios()
    {
        //var jsonFileName = @"C:\Users\da-mi\source\repos\WebApplication36\WebApplication36\wwwroot\Portfolios\portfolios.json";

        using (var jsonFileReader = File.OpenText(JsonFileName))
        {
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var portfolios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), options);
            return portfolios;
        }
    }
    }







}

