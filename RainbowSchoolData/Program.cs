using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolData
{

       public static class SchoolDatabase
        {
            public static List<Student> Students { get; } = new List<Student>();
            public static List<Teacher> Teachers { get; } = new List<Teacher>();
            public static List<Subject> Subjects { get; } = new List<Subject>();
        }

        class Program
        {
            static void Main()
            {
                
          SchoolDatabase.Students.Add(new Student { Name = "Student1", ClassAndSection = "ClassA" });
          SchoolDatabase.Students.Add(new Student { Name = "Student2", ClassAndSection = "ClassB" });

         SchoolDatabase.Teachers.Add(new Teacher { Name = "Teacher1", ClassAndSection = "ClassA" });
         SchoolDatabase.Teachers.Add(new Teacher { Name = "Teacher2", ClassAndSection = "ClassB" });

        SchoolDatabase.Subjects.Add(new Subject { Name = "Math", SubjectCode = "M101", 
            Teacher = SchoolDatabase.Teachers[0] });
       SchoolDatabase.Subjects.Add(new Subject { Name = "English", SubjectCode = "E101",
           Teacher = SchoolDatabase.Teachers[1] });

                DisplayStudentsInClass("ClassA");

                DisplaySubjectsTaughtByTeacher(SchoolDatabase.Teachers[0]);

                Console.ReadLine();
            }

            static void DisplayStudentsInClass(string className)
            {
                Console.WriteLine($"Students in {className}:");
                var studentsInClass = SchoolDatabase.Students.
                FindAll(s => s.ClassAndSection == className);
                foreach (var student in studentsInClass)
                {
                    Console.WriteLine($"{student.Name}");
                }
                Console.WriteLine();
            }

            static void DisplaySubjectsTaughtByTeacher(Teacher teacher)
            {
                Console.WriteLine($"Subjects taught by {teacher.Name} in" +
                    $" {teacher.ClassAndSection}:");
                var subjectsTaught = SchoolDatabase.Subjects.FindAll(s => s.Teacher == teacher);
                foreach (var subject in subjectsTaught)
                {
                    Console.WriteLine($"{subject.Name} ({subject.SubjectCode})");
                }
                Console.WriteLine();
            }
        }

  }


