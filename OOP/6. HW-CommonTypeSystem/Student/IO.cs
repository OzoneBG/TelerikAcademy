using System;

namespace Student
{
    class IO
    {
        static void Main()
        {
            Student student1 = new Student("Nasko", "Petrov", "Georgiev", 880008, "Bulgaria, Sofia", "088894857", 
                                            "naskodumbela@gmail.com", "third", Specialty.Informatics, University.SU, Faculty.FMI);

            Student student2 = new Student("Dinko", "Petrov", "Georgiev", 880008, "Bulgaria, Sofia", "088894857",
                                            "dinkoshtangata@gmail.com", "third", Specialty.Informatics, University.SU, Faculty.FMI);

            Console.WriteLine(student1);
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student1 == student2);

            object student1Clone = student1.Clone();
            Console.WriteLine(student1Clone.GetHashCode());
            Console.WriteLine(student1Clone);
        }
    }
}
