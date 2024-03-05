using Kodlama_io.DataAccess.Abstract;
using Kodlama_io.DataAccess.Concretes;
using Kodlama_io.Entities;

namespace Kodlama_io.Bussiness;

public class CoursesManager
{
    ICoursesDal _coursesDal;

    public CoursesManager(ICoursesDal coursesDal)
    {
        _coursesDal = coursesDal;
    }
    public void Add(Courses courses)
    {
        _coursesDal.Add(courses);
    }

    public void Delete(Courses courses)
    {
        _coursesDal.Delete(courses);
    }

    public List<Courses> GetAll()
    {
        return _coursesDal.GetAll();
    }

    public void Update(Courses courses)
    {
        _coursesDal.Update(courses);
    }
}
