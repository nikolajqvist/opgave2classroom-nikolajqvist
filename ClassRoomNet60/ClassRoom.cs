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
            
        }
    }
}
