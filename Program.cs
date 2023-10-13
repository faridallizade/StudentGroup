
namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("====== Menu ======");
                Console.WriteLine("1. Create group");
                Console.WriteLine("2. Show all students");
                Console.WriteLine("3. Add student");
                Console.WriteLine("4. Filter students by name");
                Console.WriteLine("0. Quit");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Group group = new Group(Console.ReadLine());
                            break;
                        case 2:
                            //ShowAllStudents();
                            break;
                        case 3:
                            //AddStudent();
                            break;
                        case 4:
                            //FilterbyName();
                            break;
                        case 0:
                            Console.WriteLine("The program was closed.");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose between 0-4");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose the option with just digit.");
                }

            } while (choice != 0);
        }


    }
}
