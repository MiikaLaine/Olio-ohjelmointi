using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using BookAndAuthor;

    internal class Program
    {
        static void Main(string[] args)
        {

        Book testBook1 = new Book();
        testBook1 = new Book("Ich Liebe Wiener Schnitze", "123456789012", "Jussi69", 30, "WSOY");
        //testBook1.Setname("Aapinen");
        testBook1.Name = "Ich Liebe Wiener Schnitzel";
        Console.WriteLine(testBook1);


        Console.WriteLine("Kirjan otsikko on:" + testBook1.Name);


        Book testBook2 = new Book("Pekka ja Pätkä sotarikollisina", "123456789012", "Paroni von Ungern-Stenberg", 30, "WSOY");
        testBook2.Name = "Pekka ja Pätkä sotarikollisina";
        Console.WriteLine(testBook2);

        Console.WriteLine("\nMuutetaan teema\n");
        Book.theme = "Oppikirjat";

        Console.WriteLine("Tulostetaan kirjat uudelleen\n");
        Console.WriteLine(testBook1);
        Console.WriteLine(testBook2);


      
        Author author1 = new Author ("Kalle Kustaa Korkki", "1.1.1939", testBook1);
        
        
        Console.ReadLine();
        
    }
    }
