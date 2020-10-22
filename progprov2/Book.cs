using System;

namespace progprov2
{
    public class Book
    {
        // int variabel för hur mycket pengar boken kostar:
        public int price = 0;
        // string variabel för vad boken heter:
        private string name = "";
        // int variabel för vilken ovanlighet boken har:
        private int rarity = 0;
        // string variabel för vilken katigori boken har:
        private string category = "";
        // int variabel för hur mycket boken kostar innan spelaren har värderat boken:
        private int actualValue = 0;
        // bool variabel för att avgöra om boken har en förbanelse eller int:
        private bool cursed = false;
        // en slumpgenerator som används för att slumpa fram tal:
        private Random generator = new Random();

        // syftet med konstruktorn-metoden Book är att ge actualValue ett värde från 1-10 & 
        // att ge rarity ett värde mellan 1-3
        public Book()
        {
            actualValue = generator.Next(1, 10);
            rarity = generator.Next(1,3);
        }
        // syftet med Print infor är att skriva ut namn rarity och pris i konsollen så att spelaren kan se stats för just den boken
        // detta görs genom att använda 3st console.writeLine´s där de tre variablerna skrivs ut tillsammans med en bit text.
        public void PrintInfo()
        {
            System.Console.WriteLine("book name: " + name);
            System.Console.WriteLine("rarity: " + rarity);
            System.Console.WriteLine("price: " + price);

        }
        // Evaluate returnerar ett värde 
        public int Evaluate()
        {
            return 0;

        }
        // getCategory returnerar variablen category när den blir tillfrågad. Syftet är att ta reda på vilken katogori boken har
        public string GetCategory()
        {
            return category;

        }
        // Metoden GetName returnerar variablen name. Syftet är att ta reda på vad name är för boken
        public string GetName(string name)
        {
            return name;

        }
        public bool IsCursed()
        {
            return false;

        }

    }
}
