using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employee2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //var x = Database.Query($"SELECT Name FROM Demotb1");
            //Console.WriteLine(x);
            Console.WriteLine(Settings.ConnectionString);
        }
    }
}