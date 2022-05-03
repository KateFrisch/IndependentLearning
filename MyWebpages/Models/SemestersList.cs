using System.Collections.Generic;

namespace MyWebpages.Models
{
    public class SemestersList
    {
        public string SemesterName { get; set; }
        public List<string> CourseNames { get; set; }
    }
}