using IMDB.Services.Interfaces;
using RazorPages_IMDB.Models;

namespace IMDB.Services.EF_Services
{
    public class EFTitleService : ITitleService
    {
        private TitleDBContext _dBContext;

        public EFTitleService(TitleDBContext context)
        {
            _dBContext = context;
        }
        public IEnumerable<Title> GetAllTitiles(int page)
        {
            var pageSize = 100;
            var startIndex = (page - 1) * pageSize;

            return _dBContext.Titles
                .OrderBy(t => t.Tconst)
                .Skip(startIndex)
                .Take(pageSize)
                .ToList();
        }
    }
}
