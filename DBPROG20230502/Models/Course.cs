using System;
using System.Collections.Generic;

namespace DBPROG20230502.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int? TeacherId { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
