using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; private set; }
        public int BirthdayMonth { get; private set; }
        public int BirthdayDay { get; private set; }
        public Student(string name, int birthMonth, int birthDayDay) 
        { 
            Name = name;
            BirthdayMonth = birthMonth;
            BirthdayDay = birthDayDay;
        }
    }
}
