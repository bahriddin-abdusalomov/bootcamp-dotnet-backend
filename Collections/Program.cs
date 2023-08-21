namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<ContactList> contactList = new List<ContactList>();

            //contactList.AddRange(new[] {
            //    new ContactList("Bahriddin", "Abdusalomov", "944396669", "bahriddinabdusalomov@gmail.com"),
            //    new ContactList("Lazizbek", "Xoshimov", "942950455", "laziz@gmail.com"),
            //    new ContactList("Jasur", "Ubaydullayev", "941233452", "jasur@gmail.com")
            //});


            //contactList.Add(new ContactList("Bahriddin", "Abdusalomov", "944396669", "bahriddinabdusalomov@gmail.com"));
            //contactList.Add(new ContactList("Lazizbek", "Xoshimov", "942950455", "laziz@gmail.com"));
            //contactList.Add(new ContactList("Jasur", "Ubaydullayev", "941233452", "jasur@gmail.com"));


            ContactList contactList = new ContactList();

            contactList.Add(new Contact("Bahriddin", "Abdusalomov", "944396669", "bahriddinabdusalomov@gmail.com"));
            contactList.List.Add(new Contact("Lazizbek", "Xoshimov", "942950455", "laziz@gmail.com"));
            contactList.List.Add(new Contact("Jasur", "Ubaydullayev", "(40110553", "jasur@gmail.com"));


            var user = contactList.Search("Lazizbek");

            Console.WriteLine(user.FirstName);

        }
    }
}