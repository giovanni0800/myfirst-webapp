using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstWebApplication.Pages
{
    public class ContactUsModel : PageModel
    {
        public bool hasData = false;
        public string email = "";
        public string subject = "";
        public string textBody = "";

        public void OnPost()
        {
            hasData = true;
            email = Request.Form["eMail"];
            subject = Request.Form["Subject"];
            textBody = Request.Form["Message"];
        }
    }
}
