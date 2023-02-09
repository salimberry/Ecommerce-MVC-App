using EcommerceApp.Data.Base;
using EcommerceApp.Data.ViewModels;
using EcommerceApp.Models;
using System.Threading.Tasks;

namespace EcommerceApp.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
