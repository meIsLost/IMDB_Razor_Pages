using IMDB.ViewModel;
using RazorPages_IMDB.Models;

namespace IMDB.Services.Interfaces
{
    public interface ITitleService
    {
        IEnumerable<TitleTypeIDView> GetAllTitiles(int page);
    }
}
