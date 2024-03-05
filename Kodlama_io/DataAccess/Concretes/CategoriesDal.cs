using Kodlama_io.DataAccess.Abstract;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Concretes;

public class CategoriesDal : ICategoriesDal
{
    public List<Categories> categories2;
    public CategoriesDal()
    {
        Categories category = new Categories();
        category.CategoryName = "Programlama";
        Categories category2 = new Categories();
        category2.CategoryName = "Veri Bilimi";
    }
    public void Add(Categories categories)
    {
        categories2.Add(categories);
    }

    public void Delete(Categories categories)
    {
        categories2.Remove(categories);
        Console.WriteLine("Kategori Silindi");
    }

    public List<Categories> GetAll()
    {
        return categories2;
    }

    public void Update(Categories categories)
    {
        categories.CategoryName = "Update_Categories";
    }
}
