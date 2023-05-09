using Azure.Core;
using DBPROG20230502.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace DBPROG20230502;

internal class Program
{
    static void Main()
    {
        TecContext tecContext = new TecContext();
        List<Course> courses = tecContext.Courses.Include(a => a.Teacher).ToList();
        List<Student> students = tecContext.Students.ToList();

        Console.WriteLine("Søg på lærer i database konsol program.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Indtast lærerens fornavn: ");
        var teacherFirstName = Console.ReadLine();
        if (string.IsNullOrEmpty(teacherFirstName))
        {
            Console.Clear();
            Console.WriteLine("Ingen lærer med det navn.");
            Main();
        }

        Console.WriteLine("Indtast lærerens efternavn: ");
        var teacherLastName = Console.ReadLine();
        if (string.IsNullOrEmpty(teacherLastName))
        {
            Console.Clear();
            Console.WriteLine("Ingen lærer med det navn.");
            Main();
        }

        var result = courses.Where(b => b.Teacher.FirstName.ToLower().Equals(teacherFirstName.ToLower())
        && b.Teacher.LastName.ToLower().Equals(teacherLastName.ToLower())).ToList();

        if (result.Count == 0)
        {
            Console.WriteLine("Der er ikke fundet nogen med det navn. Prøv igen.\n");            
            Main();
            return;
        }

        Console.WriteLine($"Du har søgt på: {teacherFirstName} {teacherLastName}");

        foreach (var item in result)
        {
            if (item != null)
            {
                if (item.Teacher != null)
                    
                Console.WriteLine($"\nFag: {item.CourseName}");
                Console.WriteLine($"Elever i: {item.CourseName}");
                foreach (var item2 in result)
                {
                    Console.WriteLine($"{item2.FirstName} {item2.LastName}");
                }

            }
        }
    }
}



