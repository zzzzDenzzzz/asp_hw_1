using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_hw_1.Pages
{
    public class IndexModel : PageModel
    {
        readonly Random random = new();
        public char letter;
        public void OnGet()
        {
            letter = (char)('A' + random.Next(26));
        }
    }
}