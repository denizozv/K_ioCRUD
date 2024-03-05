using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Entities;

public class Courses
{
    public int Id { get; set; }
    public String CourseName { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }

}
