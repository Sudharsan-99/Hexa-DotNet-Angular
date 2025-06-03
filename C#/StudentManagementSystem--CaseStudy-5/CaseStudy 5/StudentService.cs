using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_5
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();
        private int nextId = 1;

        public void AddStudent(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                students.Add(new Student { ID = nextId++, Name = name });
                Console.WriteLine("Student added.");
            }
            else
            {
                Console.WriteLine("Invalid name. Student not added.");
            }
        }

        public void DisplayStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
            }
        }

        public void SearchStudentByName(string name)
        {
            foreach (var student in students)
            {
                if (student.Name.ToLower() == name.ToLower())
                {
                    Console.WriteLine($"Found: ID={student.ID}, Name={student.Name}");
                    return;
                }
            }

            Console.WriteLine("Student not found.");
        }


        public void RemoveStudentByName(string name)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name.ToLower() == name.ToLower())
                {
                    students.RemoveAt(i);
                    Console.WriteLine("Student removed.");
                    return;
                }
            }

            Console.WriteLine("Student not found.");
        }


        public int CountStudents()
        {
            return students.Count;
        }
    }
}
