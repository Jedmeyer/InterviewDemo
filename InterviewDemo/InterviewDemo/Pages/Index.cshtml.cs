using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewDemo.Pages
{
    public class IndexModel : PageModel
    {
        public int IndexId { get; set; }

        public IndexModel() :base()
        {
        }

        public void OnGet()
        {

        }
    }
}