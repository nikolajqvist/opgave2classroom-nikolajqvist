using ClassRoomNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassRoom classRoom = new ClassRoom();

        classRoom.ClassName = "3B";

        classRoom.SemesterStart = new DateOnly(2025, 9, 1);

        Student s1 = new Student("Nikolaj", 12, 8);

        Student s2 = new Student("Kasper", 8, 4);

        classRoom.Students.Add(s1);
        classRoom.Students.Add(s2);


    }
}