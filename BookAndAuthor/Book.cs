using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndAuthor
{
    internal class Book
    {
        private string name;
        public int id;
        private string isbn;
        private string author;
        private double price;
        public string publisher;
        public static string theme = "Oppikirjat";
        public static int NextId = 0; //alkuarvo
        private string v1;
        private string v2;
        private int v3;
        private string v4;
        private const string PREFIX = "978";
        private const int MAXLENGHT = 13;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value == string.Empty)
                {
                    // ???? 
                }

                name = value;
            }
        }

     

        public string Isbn
        {
            get => isbn;
            set
            {
                if (value.StartsWith(PREFIX) && value.Length == MAXLENGHT)
                {
                    isbn = value;
                }
            }
        }

        public string Author { 
            get => author;}
                //set => author = value; }
        public double Price { 
            get => price; 
            set
            {
                if (value > 30)
                {
                    price = 0.9 * value;
                }
                else
                {
                    price =value;
                }
            }
        }

        public Book()
        {
            this.Name = string.Empty;
            this.id = NextId;
            NextId++;
        }

        public Book(string name, string isbn)
        {
            this.Name = name;
            this.isbn = isbn;
            this.id = NextId;
            NextId++;
        }


        public void Setname(string value)
        {
            this.Name = value;
        }

        public string GetName()
        {
            return this.Name;
        }
        public void GetBookDetails(string isbnValue)
        {
            if (this.isbn == isbnValue)

            {
                Console.WriteLine(this.ToString());
            }

            else
            
            {

                Console.WriteLine("Tietoja ei voi tulostaa");

            }
            

        }
    
        public Book(string name)
        {
            this.Name = name;
            this.id = NextId;
            NextId++;
        }

        public Book(string name, string isbn, string author, double price, string publisher) 
        {
            
            this.author = author;
            this.Price = price;
            this.publisher = publisher;
            this.isbn = isbn;
            this.id= NextId;    
            NextId++ ;  
        }

       

        public override string ToString()
        {
            return $"{this.id}, Kirjan nimi:{this.name}, isbn:{this.Isbn}, {this.Author}, {this.Price}, {this.publisher}, teema:{theme}";
          
        }

        
    }
}
