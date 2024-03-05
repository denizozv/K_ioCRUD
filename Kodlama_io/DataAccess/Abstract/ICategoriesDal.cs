using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Abstract
{
    public interface ICategoriesDal
    {
        void Add(Categories categories);
        List<Categories> GetAll();
        void Delete(Categories categories);
        void Update(Categories categories);
    }
}
