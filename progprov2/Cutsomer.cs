using System;
using System.Collections.Generic;

namespace progprov2
{
    public class Customer
    {
        // string variael för vad Customers name är:
        private string name = "";
        // string variabel för vilket katigori av bok customer är intreserad av:
        public string categoryIntrest = "";
        // int variabel för hur mycket pengar customer har:
        private int money = 0;
        // slumpgenerator för att slumpa tal (även för att slumpa vilka böcker customer kommer att få):
        private Random generator = new Random();
        // en lista för att lagra namnen på bökerna customer redan har
        private List<string> list = new List<string>();

        // syftet med kontruktorn Customer är att slumpa böker som customer redan ska ha, hur mycket pengar den kommer att ha &
        // vilket categoryIntrest customer kommer att ha.
        public Customer()
        {

        }
        // Metoden GetName returnerar variablen name. Syftet är att ta reda på vad name är för customer
        public string GetName(string name)
        {
            return name;

        }




    }
}
