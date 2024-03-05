using Kodlama_io.DataAccess.Abstract;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Concretes;

public class CoursesDal : ICoursesDal
{
    List<Courses> courses2;
    public CoursesDal(List<Instructors> instructors, List<Categories> categories)
    {
        Courses courses = new Courses();
        courses.Id = 1;
        courses.CourseName = "2024 Yazılım Geliştirici Kampı";
        courses.CategoryId = 1;
        courses.InstructorId = 1;

        Courses courses1 = new Courses();
        courses1.Id = 2;
        courses1.CourseName = "Senior Yazılımcı Kampı";
        courses1.CategoryId = 1;
        courses1.InstructorId = 1;



    }


    public void Add(Courses courses)
    {
        courses2.Add(courses);
    }

    public void Delete(Courses courses)
    {
        courses2.Remove(courses);
        Console.WriteLine("Kurs Silindi");
    }

    public List<Courses> GetAll()
    {
        return courses2;
    }

    public void Update(Courses courses)
    {
        courses.CourseName = "Update_Courses";
    }


}
