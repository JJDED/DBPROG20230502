using Azure.Core;
using DBPROG20230502.Models;
using Microsoft.EntityFrameworkCore;

namespace DBPROG20230502;

internal class Program
{
    static void Main(string[] args)
    {            
        TecContext tecContext = new TecContext();
        List<Course> courses = tecContext.Courses.Include(a => a.Teacher).ToList();
        foreach (Course item in courses)
        {
            if (item != null)
            {
                if(item.Teacher != null)
                 Console.WriteLine($"Fag: {item.CourseName}, Lærer: {item.Teacher.FirstName} {item.Teacher.LastName}");
            }
        }
    }
}



