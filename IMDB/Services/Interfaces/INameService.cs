using RazorPages_IMDB.Models;
using System.Collections.Generic;

namespace IMDB.Services.Interfaces
{
    public interface INameService
    {
        IEnumerable<Name> GetAllNames(int page);
    }
}
