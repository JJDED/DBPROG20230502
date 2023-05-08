using System;
using System.Collections.Generic;

namespace DBPROG20230502.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? Teacher { get; set; }

    public string? Course { get; set; }
}
