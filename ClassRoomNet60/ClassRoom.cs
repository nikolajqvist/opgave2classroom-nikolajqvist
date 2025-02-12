using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }

        public List<Student> Students { get; set; }
        
        public DateOnly SemesterStart { get; set; }

        public ClassRoom()
        {
            Students = new List<Student>();
        }

        public string CountOfStudentsInSeason()
        { 
            StringBuilder sb = new StringBuilder();
            var Winter = Students.Where(x => x.BirthdayMonth == 12 || x.BirthdayMonth == 1 || x.BirthdayMonth == 2);
            var Spring = Students.Where(x => x.BirthdayMonth == 3 || x.BirthdayMonth == 4 || x.BirthdayMonth == 5);
            var Summer = Students.Where(x => x.BirthdayMonth == 6 || x.BirthdayMonth == 7 || x.BirthdayMonth == 8);
            var Fall = Students.Where(x => x.BirthdayMonth == 9 || x.BirthdayMonth == 10 || x.BirthdayMonth == 11);


            sb.AppendLine($"Antallet i hver måned (vinter): {Winter.Count()}");
            sb.AppendLine($"Antallet i hver måned (forår): {Spring.Count()}");
            sb.AppendLine($"Antallet i hver måned (sommer): {Summer.Count()}");
            sb.AppendLine($"Antallet i hver måned (efterår): {Fall.Count()}");
            
            return sb.ToString();
        }

        public string AllStudents()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Student student in Students)
            {
                sb.AppendLine(student.Name);
                sb.AppendLine($"{student.BirthdayDay}");
                sb.AppendLine($"{student.BirthdayMonth}");

                sb.AppendLine(student.SeasonOfBirth());
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
