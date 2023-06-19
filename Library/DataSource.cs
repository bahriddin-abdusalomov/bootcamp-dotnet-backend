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
        new Book("The Alchemist", "Paulo Coelho", "An inspiring story about a young shepherd who travels from his homeland in Spain to the Egyptian desert in search of treasure buried near the Pyramids.", "Fantasy"),
        new Book("To Kill a Mockingbird", "Harper Lee", "A classic coming-of-age story about a young girl named Scout who learns about racism and prejudice in the American South.", "Historical Fiction"),
        new Book("1984", "George Orwell", "A dystopian novel about a totalitarian society where the government controls every aspect of people's lives.", "Science Fiction"),
        new Book("The Lord of the Rings", "J.R.R. Tolkien", "A fantasy epic about a group of hobbits who set out to destroy the One Ring, an evil artifact that threatens to destroy Middle-earth.", "Fantasy"),
        new Book("The Hunger Games", "Suzanne Collins", "A dystopian novel about a young girl who volunteers to take her younger sister's place in a deadly competition.", "Science Fiction"),
        new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "A fantasy novel about a young boy who discovers he is a wizard and is invited to attend Hogwarts School of Witchcraft and Wizardry.", "Fantasy"),
        new Book("The Catcher in the Rye", "J.D. Salinger", "A coming-of-age novel about a teenage boy named Holden Caulfield who is expelled from his boarding school and goes on a journey around New York City.", "Contemporary Fiction"),
        new Book("Pride and Prejudice", "Jane Austen", "A classic romance novel about two people from different social classes who fall in love.", "Romance"),
        new Book("The Great Gatsby", "F. Scott Fitzgerald", "A classic novel about the Roaring Twenties and the American Dream.", "Historical Fiction"),
        new Book("Beloved", "Toni Morrison", "A historical novel about a former slave who returns to her home after the Civil War.", "Historical Fiction"),
        new Book("The Color Purple", "Alice Walker", "A historical novel about a young black woman who grows up in the South during the Jim Crow era.", "Historical Fiction"),
        new Book("The Book Thief", "Markus Zusak", "A historical novel about a young girl who steals books during World War II.", "Historical Fiction"),
        new Book("The Kite Runner", "Khaled Hosseini", "A novel about friendship, betrayal, and redemption set in Afghanistan.", "Historical Fiction"),
        new Book("The Lovely Bones", "Alice Sebold", "A novel about a young girl who watches over her family from heaven after she is murdered.", "Contemporary Fiction"),
        new Book("The Curious Incident of the Dog in the Night-Time", "Mark Haddon", "A novel about a 15-year-old boy with autism who investigates the death of his neighbor's dog.", "Contemporary Fiction"),
        new Book("The Help", "Kathryn Stockett", "A novel about a young white woman who befriends two black maids in the 1960s South.", "Historical Fiction"),
        new Book("Gone Girl", "Gillian Flynn", "A thriller novel about a husband who becomes a suspect in his wife's disappearance.", "Thriller"),
        new Book("The Girl on the Train", "Paula Hawkins", "A thriller novel about a woman who becomes obsessed with a couple she sees every day on her commute.", "Thriller"),
        new Book("The Woman in the Window", "A.J. Finn", "A thriller novel about a woman who witnesses a crime from her window, but no one believes her.", "Thriller"),
        new Book("The Silent Patient", "Alex Michaelides", "A thriller novel about a therapist who is treating a woman who has been mute since the day her husband was murdered.", "Thriller"),
        new Book("The Girl with the Dragon Tattoo", "Stieg Larsson", "A thriller novel about a disgraced journalist who partners with a young female hacker to investigate the disappearance of a young woman.", "Thriller"),
        new Book("The Da Vinci Code", "Dan Brown", "A thriller novel about a symbologist who investigates the murder of a curator at the Louvre Museum and uncovers a secret society that has been protecting a powerful secret for centuries.", "Thriller"),
        new Book("The Martian", "Andy Weir", "A survival story about an astronaut who is stranded on Mars and must use his ingenuity to find a way to survive until he can be rescued.", "Science Fiction"),
        new Book("The Martian Chronicles", "Ray Bradbury", "A collection of short stories about the first contact between humans and Martians.", "Science Fiction"),
        new Book("Ender's Game", "Orson Scott Card", "A coming-of-age story about a young boy who is trained to be a military leader in a war against an alien race.", "Science Fiction"),
        new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", "A humorous novel about a man who is whisked away on an adventure through space after the Earth is destroyed.", "Sci-Fi Comedy"),
        new Book("The Hitchhiker's Guide to the Galaxy (The Radio Series)", "Douglas Adams", "A radio series that tells the same story as the novel, but with different actors and music.", "Sci-Fi Comedy"),
        new Book("The Hitchhiker's Guide to the Galaxy (The TV Series)", "Douglas Adams", "A television series that tells the same story as the novel, but with different actors and a different format.", "Sci-Fi Comedy"),
        new Book("The Hitchhiker's Guide to the Galaxy (The Movie)", "Garth Jennings", "A movie that tells the same story as the novel, but with different actors and a different format.", "Sci-Fi Comedy"),
        new Book("The Hitchhiker's Guide to the Galaxy (The Graphic Novel)", "Kevin O'Neill", "A graphic novel that tells the same story as the novel, but with illustrations.", "Sci-Fi Comedy"),
        new Book("The Hitchhiker's Guide to the Galaxy (The Video Game)", "Revolution Software", "A video game that tells the same story as the novel, but with different gameplay.", "Sci-Fi Comedy"),
        new Book("The Giver", "Lois Lowry", "A dystopian novel about a young boy who lives in a society where everyone is the same and there is no emotion.", "Young Adult Fiction"),
        new Book("The Hunger Games", "Suzanne Collins", "A dystopian novel about a young girl who volunteers to take her younger sister's place in a deadly competition.", "Young Adult Fiction"),
        new Book("Divergent", "Veronica Roth", "A dystopian novel about a young girl who discovers that she doesn't fit into any of the factions in her society.", "Young Adult Fiction"),
        new Book("The Maze Runner", "James Dashner", "A dystopian novel about a young boy who wakes up in a giant maze with a group of other boys and must find a way to escape.", "Young Adult Fiction"),
        new Book("The Fault in Our Stars", "John Green", "A novel about two teenagers who fall in love while they are both battling cancer.", "Young Adult Fiction"),
        new Book("All the Bright Places", "Jennifer Niven", "A novel about two teenagers who meet at a mental health treatment center and fall in love.", "Young Adult Fiction"),
        new Book("Paper Towns", "John Green", "A novel about a young boy who sets out to find a girl who has mysteriously disappeared.", "Young Adult Fiction"),
        new Book("Looking for Alaska", "John Green", "A novel about a young boy who attends a boarding school and falls in love with a girl who is different from anyone he has ever met before.", "Young Adult Fiction"),
        new Book("The Perks of Being a Wallflower", "Stephen Chbosky", "A novel about a shy boy who goes to high school and makes friends with two seniors who show him the world.", "Young Adult Fiction"),
        new Book("The Absolutely True Diary of a Part-Time Indian", "Sherman Alexie", "A novel about a young boy who leaves his reservation to go to a white high school.", "Young Adult Fiction"),
        new Book("The Absolutely True Diary of a Part-Time Indian (Graphic Novel)", "Sherman Alexie", "A graphic novel that tells the same story as the novel, but with illustrations.", "Young Adult Fiction"),
        new Book("The Absolutely True Diary of a Part-Time Indian (Movie)", "Sterlin Harjo", "A movie that tells the same story as the novel, but with different actors and a different format.", "Young Adult Fiction"),
        new Book("The Picture of Dorian Gray", "Oscar Wilde", "A novel about a young man who makes a deal with the devil to stay young and beautiful forever.", "Classics"),
        new Book("The Adventures of Sherlock Holmes", "Arthur Conan Doyle", "A collection of short stories about the famous detective Sherlock Holmes and his partner Dr. Watson.", "Classics"),
        new Book("The Lord of the Flies", "William Golding", "A novel about a group of boys who are stranded on an island and must learn to survive on their own.", "Classics"),
        new Book("Animal Farm", "George Orwell", "A satirical novel about a group of animals who rebel against their human masters and form their own society.", "Classics"),
        new Book("1984", "George Orwell", "A dystopian novel about a totalitarian society where the government controls every aspect of people's lives.", "Classics"),
        new Book("The Catcher in the Rye", "J.D. Salinger", "A coming-of-age novel about a teenage boy named Holden Caulfield who is expelled from his boarding school and goes on a journey around New York City.", "Classics"),
        new Book("Pride and Prejudice", "Jane Austen", "A classic romance novel about two people from different social classes who fall in love.", "Classics"),
        new Book("The Great Gatsby", "F. Scott Fitzgerald", "A classic novel about the Roaring Twenties and the American Dream.", "Classics"),
        new Book("Beloved", "Toni Morrison", "A historical novel about a former slave who returns to her home after the Civil War.", "Classics"),
        new Book("The Color Purple", "Alice Walker", "A historical novel about a young black woman who grows up in the South during the Jim Crow era.", "Classics"),
        new Book("The Book Thief", "Markus Zusak", "A historical novel about a young girl who steals books during World War II.", "Classics"),
        new Book("The Kite Runner", "Khaled Hosseini", "A novel about friendship, betrayal, and redemption set in Afghanistan.", "Classics"),
        new Book("The Lovely Bones", "Alice Sebold", "A novel about a young girl who watches over her family from heaven after she is murdered.", "Classics"),
        new Book("The Curious Incident of the Dog in the Night-Time", "Mark Haddon", "A novel about a 15-year-old boy with autism who investigates the death of his neighbor's dog.", "Classics"),
        new Book("The Help", "Kathryn Stockett", "A novel about a young white woman who befriends two black maids in the 1960s South.", "Classics"),
        new Book("Gone Girl", "Gillian Flynn", "A thriller novel about a husband who becomes a suspect in his wife's disappearance.", "Thriller"),
        new Book("The Girl on the Train", "Paula Hawkins", "A thriller novel about a woman who becomes obsessed with a couple she sees every day on her commute.", "Thriller"),
        new Book("The Woman in the Window", "A.J. Finn", "A thriller novel about a woman who witnesses a crime from her window, but no one believes her.", "Thriller"),
        new Book("The Silent Patient", "Alex Michaelides", "A thriller novel about a therapist who is treating a woman who has been mute since the day her husband was murdered.", "Thriller"),
        new Book("The Girl with the Dragon Tattoo", "Stieg Larsson", "A thriller novel about a disgraced journalist who partners with a young female hacker to investigate the disappearance of a young woman.", "Thriller"),
        new Book("The Da Vinci Code", "Dan Brown", "A thriller novel about a symbologist who investigates the murder of a curator at the Louvre Museum and uncovers a secret society that has been protecting a powerful secret for centuries.", "Thriller"),
        new Book("The Martian", "Andy Weir", "A survival story about an astronaut who is stranded on Mars and must use his ingenuity to find a way to survive until he can be rescued.", "Sci-Fi"),
        new Book("The Martian Chronicles", "Ray Bradbury", "A collection of short stories about the first contact between humans and Martians.", "Sci-Fi")
     };

        static DataSource()
        {
            var booksIndex = 0;
            for (var index = 0; index < Users.Count; index++)
            {
                if (index % 4 == 0)
                    continue;

                if (booksIndex % 4 == 0)
                    if (booksIndex + 1 == Books.Count - 1)
                        break;
                    else
                        booksIndex++;

                Books[booksIndex++].ReaderId = Users[index].Id;
            }
        }
    }
}
