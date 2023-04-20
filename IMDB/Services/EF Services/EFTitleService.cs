using IMDB.Services.Interfaces;

using IMDB.ViewModel;
using System.Data.SqlClient;
using RazorPages_IMDB.Models;

namespace IMDB.Services.EF_Services
{
    public class EFTitleService : ITitleService
    {
        //private TitleDBContext _dBContext;

        string connectionString;

        //public EFTitleService(TitleDBContext context)
        //{
        //    _dBContext = context;
        //}


        public EFTitleService(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("TitleDB");
        }

        public IEnumerable<TitleTypeIDView> ViewAllTitle()
        {

            List<TitleTypeIDView> returnList = new List<TitleTypeIDView>();
            string query = "select * from ViewAllTitle";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execute SQL commands here
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TitleTypeIDView viewAll = new TitleTypeIDView();
                        viewAll.Tconst = Convert.ToString(reader[0]);
                        viewAll.TitleTypeId = Convert.ToInt32(reader[1]);
                        viewAll.TitleType = Convert.ToString(reader[2]);
                        viewAll.PrimaryTitle = Convert.ToString(reader[3]);
                        viewAll.OriginalTitle = Convert.ToString(reader[4]);
                        viewAll.IsAdult = Convert.ToBoolean(reader[5]);



                        object value3 = reader[6];
                        if (value3 == DBNull.Value)
                        {

                            viewAll.StartYear = 0;
                        }
                        else
                        {

                            viewAll.StartYear = Convert.ToInt32(reader[6]);
                        }


                        object value =reader[7];
                        if (value == DBNull.Value)
                        {
                            
                            viewAll.EndYear = 0;
                        }
                        else
                        {
                            viewAll.EndYear = Convert.ToInt32(reader[7]);
                        }


                        object value2 = reader[8];
                        if (value2 == DBNull.Value)
                        {

                            viewAll.Runtime = 0;
                        }
                        else
                        {
                            viewAll.Runtime = Convert.ToInt32(reader[8]);
                        }


                        returnList.Add(viewAll);
                    }
                }

                return returnList;


            }
        }
        public IEnumerable<TitleTypeIDView> GetAllTitiles(int page)
        {
            var pageSize = 100;
            var startIndex = (page - 1) * pageSize;

            return ViewAllTitle()
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

        //public IEnumerable<TitleTypeIDView> join()
        //{
        //    var query = from t in _dBContext.Titles
        //                join tt in _dBContext.TitleTypes on t.TitleTypeId equals tt.TitleTypeId
        //                select new TitleTypeIDView { Tconst = t.Tconst, TitleTypeId = t.TitleTypeId,
        //TitleType = tt.TitleType1, PrimaryTitle = t.PrimaryTitle, OriginalTitle = t.OriginalTitle, IsAdult = t.IsAdult, StartYear = t.StartYear, EndYear = t.EndYear, Runtime = t.Runtime };

        //    return query.ToList();
        //}

    }
}
    