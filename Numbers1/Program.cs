namespace Numbers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[6] { 5,7,9,34,-2,-8};
          
            Array.Sort(array);
            if (array.Length > 0)
            {
                Console.WriteLine("Минимальное число: " + array[0]);
                Console.WriteLine("Максимальное число: " + array[array.Length - 1]);
            }
        }
    }
}