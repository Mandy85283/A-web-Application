using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class IntroModel : PageModel
    {
        public bool HasData = false;
        public string name = "";
        public string course = "";
        public string message = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            HasData = true;
            name = Request.Form["name"];
            course = Request.Form["course"];
            message = Request.Form["message"];
        }
    }
}
