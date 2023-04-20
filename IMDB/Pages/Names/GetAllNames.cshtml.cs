using IMDB.Services.Interfaces;
using IMDB.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_IMDB.Models;

namespace IMDB.Names
{
    public class GetAllNamesModel : PageModel
    {
        [BindProperty]
        public int MyNumber { get; set; }


        public IEnumerable<Name> Names { get; set; }


        private INameService nameService;

        public GetAllNamesModel(INameService nameService)
        {

            this.nameService = nameService;
        }
        public void OnGet(int MyNumber)
        {
            if (MyNumber == 0)
            {
                MyNumber = 1;
            }

            Names = nameService.GetAllNames(MyNumber);
        }
        public void OnPost()
        {

            if (MyNumber == 0)
            {
                MyNumber = 1;
            }

            Names = nameService.GetAllNames(MyNumber);
        }
    }
}
