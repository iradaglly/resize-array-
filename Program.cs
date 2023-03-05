namespace resize_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Please enter the size of the array");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[sizeArray];
            int increment = 0;
            do
            {
                Console.WriteLine("Enter element ");
                numbers[increment] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Do you want to continue? ");

                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    increment++;
                    Array.Resize(ref numbers, numbers.Length + 1);
                }
                else
                {
                    flag = false;
                    Console.WriteLine("...exiting");
                    break;
                }


            } while (flag);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}