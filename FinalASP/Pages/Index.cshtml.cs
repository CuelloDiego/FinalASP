using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FinalASP.Models;

namespace FinalASP.Pages
{
    public class IndexModel : PageModel
    {
        public  List<Product> ProdList { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IDataSource data)
        {
            _logger = logger;

            ProdList = data.GetAll();

        }

        public void OnGet()
        {

        }
    }
}