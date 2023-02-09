using EcommerceApp.Data.Base;
using EcommerceApp.Models;

namespace EcommerceApp.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
