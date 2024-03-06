using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BookAndAuthor
{
    internal class Author
    {

        private string name;
        private string birthday;
        private Book book;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Birthday { get => birthday; set => birthday = value; }
        internal Book Book
        {
            get => book;
            set
            {
                if (value.Author == this.name)
                {
                    book = value;
                }
            }

        }

        public Author(string name, string birthday, Book book)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Book = book;
        }
        public void PrintInformation()
        {
            Console.WriteLine(this.ToString());

        }
        public override string ToString()
        {
            return $"{this.name}, {this.Birthday}, kirja: {this.book}";
        

}
}
    
    }
    

