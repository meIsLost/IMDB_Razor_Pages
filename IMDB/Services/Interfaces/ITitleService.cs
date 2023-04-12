using RazorPages_IMDB.Models;

namespace IMDB.Services.Interfaces
{
    public interface ITitleService
    {
        IEnumerable<Title> GetAllTitiles(int page);
    }
}
