using IMDB.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_IMDB.Models;

namespace IMDB.Pages.Ttiles
{
    public class GetAllTitlesModel : PageModel
    {
        [BindProperty]
        public int MyNumber { get; set; }

        public IEnumerable<Title> Titles { get; set; }


        private ITitleService titleService;

        public GetAllTitlesModel(ITitleService titleService)
        {

            this.titleService = titleService;
        }
        public void OnGet(int MyNumber)
        {
            if (MyNumber == 0)
            {
                MyNumber = 1;
            }

            Titles = titleService.GetAllTitiles(MyNumber);
        }
        public void OnPost()
        {

            if (MyNumber == 0)
            {
                MyNumber = 1;
            }

            Titles = titleService.GetAllTitiles(MyNumber);
        }

    }
}
