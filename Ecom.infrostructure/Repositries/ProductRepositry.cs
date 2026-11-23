using Ecom.Core.Interfaces;
using Ecom.infrostructure.Data;

namespace Ecom.infrostructure.Repositries
{
    public class ProductRepository : IProductRepositry
    {
        private readonly AppDbContex _context;

        public ProductRepository(AppDbContex context)
        {
            _context = context;
        }
    }
}
