using EcommerceApp.Data.Base;
using EcommerceApp.Models;

namespace EcommerceApp.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
