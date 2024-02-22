namespace Variables_Justin_Palmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer to store named favoriteNumber 
            int favoriteNumber;
            // Booleans intialized to false for jumping and running
            bool isJumping = false, isRunning = false;
            // Declares ramdom float variable
            float myFloat;
            // Assigning the favoriteNumber to 9
            favoriteNumber = 9;
            // Assigning myFloat to 54.65
            myFloat = 54.65f;
            // intializing constant finalGrade to 90
            const double finalGrade = 90.0;

            // Prints all variables to console
            Console.WriteLine("Favorite #:" + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}