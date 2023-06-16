using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Autor { get; set; }

        public string Category { get; set; }

        public Guid? ReaderId { get; set; }

        public Book(string name, string autor)
        {
            Id = Guid.NewGuid();
            Name = name;
            Autor = autor;
        }

        public override string ToString()
        {
            return $"\nID: {Id}" +
                     $"\nKitobning nomi: {Name}," +
                     $"\nMuallifi: {Autor}" +
                     $"\nKim o'qiyapti: {ReaderId}";
        }
    }
}
