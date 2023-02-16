namespace GitCheckpoint1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Git checkpoint task 1.1");
            testMessage("Task 2 checked");
            Calculate.Add(2, 3);
        }

        static void testMessage(string v)
        {
            Console.WriteLine(v);
        }
    }
}