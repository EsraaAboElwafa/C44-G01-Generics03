namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("samer", 101);
            students.Add("Esraa", 102);
            students.Add("Omar", 103);

            Console.WriteLine("Esraa's seat number is: " + students["Esraa"]);

            if (students.ContainsKey("Ali"))
            {
                Console.WriteLine("Ali is in the list.");
            }

            students["Ali"] = 110;

            students.Remove("Omar");

            Console.WriteLine("\nAll students:");
            foreach (var pair in students)
            {
                Console.WriteLine($"Name: {pair.Key}, Seat: {pair.Value}");
            }

        }
    }
}
