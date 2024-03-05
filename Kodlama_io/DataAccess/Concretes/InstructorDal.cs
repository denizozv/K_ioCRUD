using Kodlama_io.DataAccess.Abstract;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructors> instructors;
    public InstructorDal()
    {
        Instructors instructors4 = new Instructors();
        instructors4.Id = 1;
        instructors4.Name = "Engin Demiroğ";
        Instructors instructors5 = new Instructors();
        instructors5.Id = 2;
        instructors5.Name = "Halit Enes Kalaycı";

    }
    public void Add(Instructors instructorsNew)
    {
        instructors.Add(instructorsNew);
    }

    public void Delete(Instructors instructorsNew)
    {
        instructors.Remove(instructorsNew);
        Console.WriteLine("Silindi");
    }

    public List<Instructors> GetAll()
    {
        return instructors;
    }

    public void Update(Instructors instructorsNew)
    {
        instructorsNew.Name = "Update_Instructors";
    }
}
