//Assignment 11.3
//Create a WinForm app with CRUD operations using EF Core with SQLite.
//The app should allow users to perform CRUD operations on a database of movies.
//The database should use two classes: Movies and Genres.
//provide a user interface for managing many to one relationships between movies and genre.

namespace Assginment_11._3
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
            Application.Run(new MainForm());
        }
    }
}