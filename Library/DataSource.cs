using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class DataSource
    {
        public static List<User> Users { get; set; } = new()
     {
         new User("John", "Smith", "jsmith"),
         new User("Emily", "Johnson", "ejohnson"),
         new User("Michael", "Williams", "mwilliams"),
         new User("Emma", "Jones", "ejones"),
         new User("Daniel", "Brown", "dbrown"),
         new User("Olivia", "Davis", "odavis"),
         new User("Matthew", "Miller", "mmiller"),
         new User("Sophia", "Wilson", "swilson"),
         new User("William", "Taylor", "wtaylor"),
         new User("Ava", "Anderson", "aanderson"),
         new User("James", "Thomas", "jthomas"),
         new User("Isabella", "Jackson", "ijackson"),
         new User("Benjamin", "Harris", "bharris"),
         new User("Mia", "Clark", "mclark"),
         new User("Jacob", "Lewis", "jlewis"),
         new User("Charlotte", "Lee", "clee"),
         new User("Ethan", "Walker", "ewalker"),
         new User("Amelia", "Hall", "ahall"),
         new User("Alexander", "Young", "ayoung"),
         new User("Grace", "Turner", "gturner")
     };

        public static List<Book> Books { get; set; } = new()
     {
         new Book("To Kill a Mockingbird", "Harper Lee"),
         new Book("1984", "George Orwell"),
         new Book("Pride and Prejudice", "Jane Austen"),
         new Book("The Great Gatsby", "F. Scott Fitzgerald"),
         new Book("The Catcher in the Rye", "J.D. Salinger"),
         new Book("Moby-Dick", "Herman Melville"),
         new Book("The Lord of the Rings", "J.R.R. Tolkien"),
         new Book("Jane Eyre", "Charlotte Bronte"),
         new Book("The Chronicles of Narnia", "C.S. Lewis"),
         new Book("Brave New World", "Aldous Huxley"),
         new Book("The Hobbit", "J.R.R. Tolkien"),
         new Book("Frankenstein", "Mary Shelley"),
         new Book("The Adventures of Tom Sawyer", "Mark Twain"),
         new Book("Alice's Adventures in Wonderland", "Lewis Carroll"),
         new Book("The Picture of Dorian Gray", "Oscar Wilde"),
         new Book("Wuthering Heights", "Emily Bronte"),
         new Book("The Odyssey", "Homer"),
         new Book("Lord of the Flies", "William Golding"),
         new Book("Crime and Punishment", "Fyodor Dostoevsky"),
         new Book("The Scarlet Letter", "Nathaniel Hawthorne"),
         new Book("One Hundred Years of Solitude", "Gabriel Garcia Marquez"),
         new Book("To the Lighthouse", "Virginia Woolf"),
         new Book("The Brothers Karamazov", "Fyodor Dostoevsky"),
         new Book("Catch-22", "Joseph Heller"),
         new Book("The Grapes of Wrath", "John Steinbeck"),
         new Book("The Old Man and the Sea", "Ernest Hemingway"),
         new Book("The Hobbit", "J.R.R. Tolkien"),
         new Book("The Kite Runner", "Khaled Hosseini"),
         new Book("The Alchemist", "Paulo Coelho"),
         new Book("Slaughterhouse-Five", "Kurt Vonnegut"),
         new Book("A Tale of Two Cities", "Charles Dickens"),
         new Book("Don Quixote", "Miguel de Cervantes"),
         new Book("The Count of Monte Cristo", "Alexandre Dumas"),
         new Book("Anna Karenina", "Leo Tolstoy"),
         new Book("The Shining", "Stephen King"),
         new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling"),
         new Book("The Little Prince", "Antoine de Saint-Exupery"),
         new Book("The Divine Comedy", "Dante Alighieri"),
         new Book("Gone with the Wind", "Margaret Mitchell"),
         new Book("The Adventures of Sherlock Holmes", "Arthur Conan Doyle"),
         new Book("Pippi Longstocking", "Astrid Lindgren"),
         new Book("The Giver", "Lois Lowry"),
         new Book("The Hunger Games", "Suzanne Collins"),
         new Book("The Fault in Our Stars", "John Green"),
         new Book("A Game of Thrones", "George R.R. Martin"),
         new Book("The Chronicles of Narnia", "C.S. Lewis"),
         new Book("War and Peace", "Leo Tolstoy"),
         new Book("The Odyssey", "Homer"),
         new Book("The Girl with the Dragon Tattoo", "Stieg Larsson"),
         new Book("The Da Vinci Code", "Dan Brown"),
         new Book("The Road", "Cormac McCarthy"),
         new Book("The Handmaid's Tale", "Margaret Atwood"),
         new Book("The Book Thief", "Markus Zusak"),
         new Book("A Clockwork Orange", "Anthony Burgess"),
         new Book("The Sun Also Rises", "Ernest Hemingway"),
         new Book("The Stranger", "Albert Camus"),
         new Book("The Secret Garden", "Frances Hodgson Burnett"),
         new Book("Winnie-the-Pooh", "A.A. Milne"),
         new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams"),
         new Book("The Call of the Wild", "Jack London")
     };

        static DataSource()
        {
            var booksIndex = 0;
            for (var index = 0; index < 20; index++)
            {
                if (index % 4 == 0)
                    continue;

                if (booksIndex == Books.Count - 1)
                    break;

                do
                {
                    Books[index].ReaderId = Users[index].Id;
                } while (booksIndex % 3 != 0);
            }
        }
    }
}
