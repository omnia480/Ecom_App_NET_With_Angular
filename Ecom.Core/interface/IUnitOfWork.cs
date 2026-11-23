using Ecom.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Core.Interfaces
{
   public  interface IUnitOfWork  
    {
        public ICategoryRepository  CategoryRepository { get; }
        public IPhotoRepository PhotoRepository { get; }
        public IProductRepositry ProductRepository { get; }
    }
}
