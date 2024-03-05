using Kodlama_io.Entities;

namespace Kodlama_io.DataAccess.Abstract
{
    public interface ICoursesDal
    {
        void Add(Courses courses);
        List<Courses> GetAll();
        void Delete(Courses courses);
        void Update(Courses courses);
    }
}
