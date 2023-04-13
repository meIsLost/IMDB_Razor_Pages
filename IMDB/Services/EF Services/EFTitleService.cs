using IMDB.Services.Interfaces;
using IMDB.ViewModel;
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
        public IEnumerable<TitleTypeIDView> GetAllTitiles(int page)
        {
            var pageSize = 100;
            var startIndex = (page - 1) * pageSize;

            return join()
                .OrderBy(t => t.Tconst)
                .Skip(startIndex)
                .Take(pageSize)
                .ToList();
        }

        //public IEnumerable<TitleTypeIDView> join()
        //{
        //    var query = from t in _dBContext.Titles
        //                join tt in _dBContext.TitleTypes on t.TitleTypeId equals tt.TitleTypeId
        //                select new TitleTypeIDView { t.Tconst,  tt.TitleTypeId , t.PrimaryTitle, t.OriginalTitle, t.IsAdult, t.StartYear, t.EndYear,t.Runtime};

        //    return query.ToList();
        //}

        public IEnumerable<TitleTypeIDView> join()
        {
            var query = from t in _dBContext.Titles
                        join tt in _dBContext.TitleTypes on t.TitleTypeId equals tt.TitleTypeId
                        select new TitleTypeIDView { Tconst = t.Tconst, TitleTypeId = t.TitleTypeId,
        TitleType = tt.TitleType1, PrimaryTitle = t.PrimaryTitle, OriginalTitle = t.OriginalTitle, IsAdult = t.IsAdult, StartYear = t.StartYear, EndYear = t.EndYear, Runtime = t.Runtime };

            return query.ToList();
        }

    }
}
    