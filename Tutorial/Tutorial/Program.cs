namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie avengers = new Movie("The Avengers", "Joss WHedon", "Dog");

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();

        }
    }


}