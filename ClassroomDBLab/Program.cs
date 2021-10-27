using System;
using System.Linq;

namespace ClassroomDBLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(ClassContext context = new ClassContext())
            {
                if(context.Students.Count() == 0)
                {
                    CreateDB();
                }
            }
            //CreateDB();
            DisplayAllDB();
            DisplayStudentDB();
        }

        static void DisplayStudentDB()
        {
            int id = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter an ID number.");
                    id = int.Parse(Console.ReadLine());
                    using (ClassContext context = new ClassContext())
                    {
                        Student result = context.Students.Single(s => s.StudentID == id);

                        Console.WriteLine($"{result.Name}'s favorite food is {result.favFood} and their hometown is {result.Hometown}.");
                    }
                    break;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("That wasn't a number.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("No such student. Try again.");
                }
            }

            
        }

        static void DisplayAllDB()
        {
            using (ClassContext context = new ClassContext())
            {
                foreach(Student s in context.Students)
                {
                    Console.WriteLine($"{s.StudentID}. {s.Name}");
                }
            }
        }

        static void CreateDB()
        {
            using(ClassContext context = new ClassContext())
            {
                Student s1 = new Student
                {
                    Name = "Radeen",
                    Hometown = "Detroit",
                    favFood = "Tacos"
                };
                Student s2 = new Student
                {
                    Name = "Luffy",
                    Hometown = "East Blue",
                    favFood = "Meat"
                };
                Student s3 = new Student
                {
                    Name = "Zoro",
                    Hometown = "East Blue",
                    favFood = "Sake"
                };
                Student s4 = new Student
                {
                    Name = "Nami",
                    Hometown = "East Blue",
                    favFood = "Tangerines"
                };
                Student s5 = new Student
                {
                    Name = "Sanji",
                    Hometown = "North Blue",
                    favFood = "Spicy Seafood Pasta"
                };
                Student s6 = new Student
                {
                    Name = "Usopp",
                    Hometown = "Autumn Island",
                    favFood = "Pike"
                };

                context.Students.Add(s1);
                context.Students.Add(s2);
                context.Students.Add(s3);
                context.Students.Add(s4);
                context.Students.Add(s5);
                context.Students.Add(s6);

                context.SaveChanges();
            }
        }
    }
}
