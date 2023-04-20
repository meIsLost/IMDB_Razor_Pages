using IMDB.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using RazorPages_IMDB.Models;

namespace IMDB.Services.EF_Services
{
    public class EFNameService : INameService
    {
        private TitleDBContext _dBContext;


        public EFNameService (TitleDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public IEnumerable<Name> GetAllNames(int page)
        {

            var pageSize = 100;
            var startIndex = (page - 1) * pageSize;

            return  _dBContext.Names.OrderBy(t => t.Nconst)
                .Skip(startIndex)
                .Take(pageSize)
                .ToList();


        }
    }
}
