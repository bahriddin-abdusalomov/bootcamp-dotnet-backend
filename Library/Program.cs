namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var libraryManagement = new LibraryManagementCore(DataSource.Books, DataSource.Users);

            libraryManagement.DisplayAllUsers();
            libraryManagement.DisplayAllBooks();
        }
    }
}