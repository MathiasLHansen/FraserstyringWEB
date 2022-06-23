using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Services;
using MyWebApp.Models;

namespace MyWebApp.Pages
{
    public class DatedPhraseModel : PageModel
    {

        public List<DatedPhrase> DatedPhrases = new();
        [BindProperty]
        public DatedPhrase newDatedPhrase{get; set;}
        public void OnGet()
        {
            DatedPhrases = DatedPhraseService.GetAll();
        }

        public void OnPostTest(){
            Console.Write("teeeeest");
        }
    }
}
