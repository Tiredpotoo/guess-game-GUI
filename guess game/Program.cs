namespace guess_game
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new menu());
            int guess = 0;
            int num = random();
        }
        static int random()
        {
            Random random = new Random();
            return (int)random.Next(0, 10);
        }
    }
}