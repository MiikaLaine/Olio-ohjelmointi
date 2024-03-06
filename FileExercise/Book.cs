using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExercise
{
    class Book
    {
        private string title;
        private string author;
        private string price;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Price { get => price; set => price = value; }

        public Book() {
        
        }

        public override string? ToString()
        {
            return $"Title: {title}, Author: {author}, Price: {price}";
                {


            }
        }
    }  



    }
    
    
 

