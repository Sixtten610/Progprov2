using System;

namespace progprov2
{
    class Program
    {
        static void Main(string[] args)
        {
            // här skapar skapar jag en class "book" samt en klass "customer", syftet med detta är att kunna använda
            // instansen genom att skicka information som exempelvis namn på boken eller kunden
            Book book = new Book();
            Customer customer = new Customer();

            // här tillkallar jag metoden för spel-loopen, syftet är att inte skriva kod i main därför har jag skapat en metod där
            // all spelkod kan skrivas
            // jag tar även med book och customer med syftet att ska kunna användas och tillkallas i GameLoop
            GameLoop(book, customer);
            
        }

        // i gameloop tar jag emot book och namnger den samma och detta gör jag även med customer
        // i metoden tillkallar jag book.Getname vilken är en public metod i klassen Book. Jag inputar även med metoden GetBookName
        // syfter med detta kodblock är att köra spelet i och tillkalla andra metoder för att undvika kod i Main
        static void GameLoop(Book book, Customer customer)
        {
            book.GetName(GetBookName());
            Console.ReadLine();
        }

        // syftet med GetBookName är att ta in namn för boken (eller en textrad). 
        //Först hänvisas spelaren att skriva in namnet, vilken sedan returneras när hen
        // trycker på enter eftersom det är en ReadLine
        static string GetBookName()
        {
            System.Console.WriteLine("enter book name:");
            return Console.ReadLine();
        }
    }
}
