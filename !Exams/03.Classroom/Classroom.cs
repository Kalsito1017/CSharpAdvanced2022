using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public List<Student> students { get; set; }
        public int Count => students.Count;
        public int Capacity { get; set; }
        public Classroom(int capacity)
        {
            students = new List<Student>();
            Capacity = capacity;
        }
        public string RegisterStudent(Student student)
        {
            if (Capacity > Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
           return $"No seats in the classroom";
        }
        public string DismissStudent(string firstName, string lastName)
        {
            if (students.Any(x => x.FirstName == firstName && x.LastName == lastName))
            {
                Student student = students.First(s => s.FirstName == firstName && s.LastName == lastName);
                students.Remove(student);
                return $"Dismissed student {firstName} {lastName}";
            }
            return "Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            if (students.All(x => x.Subject != subject))    
            {
                return "No students enrolled for the subject";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            foreach (var stundet in students.Where(s => s.Subject == subject))
            {
                sb.AppendLine($"{stundet.FirstName} {stundet.LastName}");
            }
            return sb.ToString();
        }
        public int GetStudentsCount() => Count;
        public Student GetStudent(string firstName, string lastName) => students.First(s => s.FirstName == firstName && s.LastName == lastName);
        

        
        


    }
}
