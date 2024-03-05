using Kodlama_io.Bussiness;
using Kodlama_io.DataAccess.Abstract;
using Kodlama_io.DataAccess.Concretes;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoriesManager categoriesManager = new CategoriesManager(new CategoriesDal());
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());

            List<Instructors> instructors = instructorManager.GetAll();
            List<Categories> categoriess = categoriesManager.GetAll();

            CoursesManager coursesManager = new CoursesManager(new CoursesDal(instructors, categoriess));
            List<Courses> courses = coursesManager.GetAll();

            Course(instructors, categoriess, coursesManager, courses);

            Category(categoriesManager, categoriess);

            Instructor(instructorManager, instructors);



        }

        private static void Instructor(InstructorManager instructorManager, List<Instructors> instructors)
        {


            Console.WriteLine("Instructor Create");
            Console.WriteLine("-----------------");

            instructorManager.Add(new Instructors() { Id = 1, Name = "Insturctor" });

            Console.WriteLine("Instructors GetAll");
            Console.WriteLine("---------------");

            if (instructors.Count > 0)
            {
                foreach (var item in instructors)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                }
            }




            Console.WriteLine("Instructor Delete");
            Console.WriteLine("-----------------");
            instructorManager.Delete(instructors.First());
            if (instructors.Count > 0)
            {
                foreach (var item in instructors)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                }
            }

            Console.WriteLine("Instructor Update");
            Console.WriteLine("---------------");

            instructorManager.Update(instructors.First());
            if (instructors.Count > 0)
            {
                foreach (var item in instructors)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                }
            }




        }
        
        private static void Category(CategoriesManager categoriesManager, List<Categories> categories)
        {
            Console.WriteLine("Create Category");
            Console.WriteLine("---------------");

            categoriesManager.Add(new Categories { Id = 3, CategoryName = "Oyun geliştirme" });

            Console.WriteLine("Cateories GetAll");
            Console.WriteLine("---------------");

            if (categories.Count>0)
            {
                foreach (var item in categories)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CategoryName);
                }
            }

            Console.WriteLine("Category Delete");
            Console.WriteLine("---------------");

            if (categories.Count > 0)
            {
                foreach (var item in categories)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CategoryName);
                }
            }

            categoriesManager.Delete(categories.First());

            Console.WriteLine("Category Update");
            Console.WriteLine("---------------");

            categoriesManager.Update(categories.First());
            if (categories.Count > 0)
            {
                foreach (var item in categories)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CategoryName);
                }
            }
            

        }

        private static void Course(List<Instructors> instructors, List<Categories> categories, CoursesManager coursesManager, List<Courses> courses)
        {
            Console.WriteLine("Course Category");
            Console.WriteLine("---------------");

            coursesManager.Add(new Courses { CategoryId = 3, CourseName = "java", InstructorId = 1 });

            Console.WriteLine("Course GetAll");
            Console.WriteLine("---------------");

            if (courses.Count > 0)
            {
                foreach (var item in courses)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CourseName);
                    Console.WriteLine(item.CategoryId);
                    Console.WriteLine(item.InstructorId);
                }
            }

            Console.WriteLine("Course Delete");
            Console.WriteLine("---------------");

            if (courses.Count > 0)
            {
                foreach (var item in courses)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CourseName);
                    Console.WriteLine(item.CategoryId);
                    Console.WriteLine(item.InstructorId);
                }
            }

            coursesManager.Delete(courses.First());

            Console.WriteLine("Course Update");
            Console.WriteLine("---------------");

            coursesManager.Update(courses.First());
            if (courses.Count > 0)
            {
                foreach (var item in courses)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.CourseName);
                    Console.WriteLine(item.CategoryId);
                    Console.WriteLine(item.InstructorId);
                }
            }
        }

    }
}