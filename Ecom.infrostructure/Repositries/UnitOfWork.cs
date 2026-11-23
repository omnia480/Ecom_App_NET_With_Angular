using Ecom.Core.Interfaces;
using Ecom.infrostructure.Data;

namespace Ecom.infrostructure.Repositries
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContex _context;

        public ICategoryRepository CategoryRepository { get; }
        public IPhotoRepository PhotoRepository { get; }
        public IProductRepositry ProductRepository { get; }

        public UnitOfWork(AppDbContex contex)
        {
            _context = contex;
            CategoryRepository = new CategoryRepository(_context);
            PhotoRepository = new PhotoRepository(_context);
            ProductRepository = new ProductRepository(_context);
        }
    }

    public class PhotoRepository : IPhotoRepository
    {
        private readonly AppDbContex _context;

        public PhotoRepository(AppDbContex context)
        {
            _context = context;
        }
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContex _context;

        public CategoryRepository(AppDbContex context)
        {
            _context = context;
        }
    }
}
