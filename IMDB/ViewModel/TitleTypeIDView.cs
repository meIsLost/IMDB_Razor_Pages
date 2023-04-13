using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IMDB.ViewModel
{
    public class TitleTypeIDView
    {
        public string? Tconst { get; set; }

        public int? TitleTypeId { get; set; }

        public string? PrimaryTitle { get; set; }
      
        public string? OriginalTitle { get; set; }
     
        public bool? IsAdult { get; set; }
        
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? Runtime { get; set; }

        public string? TitleType { get; set; }
    }
}
