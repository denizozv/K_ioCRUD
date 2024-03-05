using Kodlama_io.DataAccess.Abstract;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Bussiness;

public class CategoriesManager
{
    ICategoriesDal _categoriesDal;

    public CategoriesManager(ICategoriesDal categoriesDal)
    {
        _categoriesDal = categoriesDal;
    }
    public void Add(Categories categories)
    {
        _categoriesDal.Add(categories);
    }

    public void Delete(Categories categories)
    {
        _categoriesDal.Delete(categories);
    }

    public List<Categories> GetAll()
    {
        return _categoriesDal.GetAll();
    }

    public void Update(Categories categories)
    {
        _categoriesDal.Update(categories);
    }


}
