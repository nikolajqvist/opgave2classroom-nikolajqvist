using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        private int _birthdayMonth;
        public string Name { get; private set; }
        [Required]
        [Range(1, 12)]
        public int BirthdayMonth { get; set; }
        public int BirthdayDay { get; private set; }
        public Student(string name, int birthMonth, int birthDayDay) 
        { 
            if(BirthdayMonth > 12 || BirthdayMonth < 0)
            {
                throw new ArgumentOutOfRangeException($"Du kan ikke føde folk udenfor 1 til 12 måned {BirthdayMonth}");
            }
            if (BirthdayDay < 0 || BirthdayDay > 31)
            {
                throw new ArgumentOutOfRangeException($"Der ikke nogle måneder over 31 eller mindre end 0 {BirthdayDay}");
            }
            Name = name;
            BirthdayMonth = birthMonth;
            BirthdayDay = birthDayDay;
        }

        public string SeasonOfBirth()
        {
            switch (this.BirthdayMonth)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";

                case 3:
                case 4:
                case 5:
                    return "Spring";

                case 6:
                case 7:
                case 8:
                    return "Sommer";

                case 9:
                case 10:
                case 11:
                    return "Fall";
            }
                return "Monster alien baby";
        }
    }
}
