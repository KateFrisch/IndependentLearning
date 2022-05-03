using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebpages.Models;

namespace MyWebpages.Pages
{
    public class CoursesModel : PageModel
    {
        public List<SubjectList> Subjects { get; set; }
        public List<SemestersList> Semesters { get; set; }

        public void OnGet()
        {
            Subjects = new List<SubjectList>  {
                new SubjectList()
                {
                    SubjectName = "Computer Science",
                    CourseNames = new List<string> {
                        "Software Engineering",
                        "Web Design",
                        "Database Management Systems",
                        "Web Application Development",
                        "Design and Analysis of Algorithms",
                        "Advanced Programming",
                        "Assembly Language and Computer Architecture",
                        "Data Structures",
                        "Intro to Software Development",
                        "Multimedia Python Programming"
                    } },
                new SubjectList() {
                    SubjectName = "Mathematics",
                    CourseNames = new List<string> {
                        "Calculus I",
                        "Calculus II",
                        "Discrete Structures",
                        "Theory of Computation",
                        "Linear Algebra",
                        "Foundation of Mathematics"
                    } },
                new SubjectList() {
                    SubjectName = "Creative Arts",
                    CourseNames = new List<string> {
                        "Digital Art and Design",
                        "Painting",
                        "Drawing",
                        "Basic Design",
                        "Modern Dance",
                        "Ballet"
                    } }


            };

            Semesters = new List<SemestersList> {
                new SemestersList()
                {
                    SemesterName = "Spring 2022",
                    CourseNames = new List<string>
                    {
                        "Software Engineering II",
                        "Web Design",
                        "Digital Art and Design",
                        "Communications Law and Ethics"
                    }
                },
                new SemestersList()
                {
                    SemesterName = "Fall 2021",
                    CourseNames = new List<string>
                    {
                        "Software Engineering I",
                        "Painting I",
                        "Astronomy",
                        "The Short Story"
                    }
                },
                new SemestersList()
                {
                    SemesterName = "Spring 2021",
                    CourseNames = new List<string>
                    {
                       "Drawing I",
                        "Web Application Development",
                        "3D Virtual Programming",
                        "Theory of Computation",
                        "History of Satan"
                    }
                },
                new SemestersList()
                {
                    SemesterName = "Fall 2020",
                    CourseNames = new List<string>
                    {
                        "Assembly Language and Computer Architecture",
                        "Database Management Systems",
                        "Business Statistics I",
                        "The Family"
                    }
                },
                new SemestersList()
                {
                    SemesterName = "Spring 2020",
                    CourseNames = new List<string>
                    {
                       "Modern Dance",
                        "Advanced Programming",
                        "Design+Analysis of Algorithms",
                        "Game Programming in Unity",
                        "Intro to Religious Thought"
                    }
                },
                new SemestersList()
                {
                    SemesterName = "Fall 2019",
                    CourseNames = new List<string>
                    {
                        "Basic Design I",
                        "Ballet",
                        "Data Structures",
                        "Discrete Structures",
                        "Philosophy and the Human Being"
                    }
                },
                new SemestersList()
                {
                    SemesterName = "Spring 2019",
                    CourseNames = new List<string>
                    {
                        "Digital Photography I",
                        "Intro to Software Development",
                        "FYSM 101: Nerd Knowledge",
                        "Linear Algebra",
                        "Foundation of Mathematics"
                    }
                },
                new SemestersList()
                {
                    SemesterName = "Fall 2018",
                    CourseNames = new List<string>
                    {
                        "Multimedia Python Programming",
                        "FYSM 100: Nerd Knowledge",
                        "West and the World 1500-1900",
                        "Calculus II",
                        "Mathematical Problem Solving"
                    }
                }

            };
        }
    }
}
