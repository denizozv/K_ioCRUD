using Kodlama_io.Entities;

namespace Kodlama_io.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructors instructors);
        List<Instructors> GetAll();
        void Delete(Instructors instructors);
        void Update(Instructors instructors);
    }
}
