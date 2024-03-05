using Kodlama_io.DataAccess.Abstract;
using Kodlama_io.DataAccess.Concretes;
using Kodlama_io.Entities;

namespace Kodlama_io.Bussiness;

public class InstructorManager
{
    IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructors instructors)
    {
        _instructorDal.Add(instructors);
    }

    public void Delete(Instructors instructors)
    {
        _instructorDal.Delete(instructors);
    }

    public List<Instructors> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public void Update(Instructors instructors)
    {
        _instructorDal.Update(instructors);
    }
}
