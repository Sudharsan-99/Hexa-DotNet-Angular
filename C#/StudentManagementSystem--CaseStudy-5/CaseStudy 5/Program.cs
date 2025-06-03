namespace CaseStudy_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService();

            while (true)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student by Name");
                Console.WriteLine("4. Remove Student by Name");
                Console.WriteLine("5. Count Total Students");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option (1-6): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string nameToAdd = Console.ReadLine();
                        service.AddStudent(nameToAdd);
                        break;

                    case "2":
                        service.DisplayStudents();
                        break;

                    case "3":
                        Console.Write("Enter name to search: ");
                        string searchName = Console.ReadLine();
                        service.SearchStudentByName(searchName);
                        break;

                    case "4":
                        Console.Write("Enter name to remove: ");
                        string removeName = Console.ReadLine();
                        service.RemoveStudentByName(removeName);
                        break;

                    case "5":
                        Console.WriteLine($"Total number of students: {service.CountStudents()}");
                        break;

                    case "6":
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number from 1 to 6.");
                        break;
                }
            }
        }
    }
}
