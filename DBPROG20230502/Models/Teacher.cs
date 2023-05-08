using System;
using System.Collections.Generic;

namespace DBPROG20230502.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
