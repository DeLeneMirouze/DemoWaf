using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoWaf.Pages
{
    public class IndexModel : PageModel
    {

        public IndexModel()
        {
          
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(string cadeau)
        {
            return RedirectToPage("./Merci");
        }
    }
}