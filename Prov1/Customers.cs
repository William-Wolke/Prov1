using System;

namespace Prov1
{
    public class Customers
    {
        public string name;

        private string type;

        private int money;
        //Alla customers kan högst ha 10 böker innan de går in i affären
        private string[] booksOwned = new string[10];

        private Random generator = new Random();

        public Customers(){
            
        }

        public void PrintCustomerInfo(){
            System.Console.WriteLine(GetCustomerName());
            System.Console.WriteLine(GetType());
        }

        public string GetCustomerName(){
            return "Sean Banan"
        }

        public string GetType(){
            return "gamer";
        }

        public string[] GetOwnedBooks(){

            string[] books = {"Bibeln 2: Potatis-Moses återkomst"};

            //Här hade jag kunnat göra så att Books och Customers delar på variabeln books, det hade varit mycket smidigare.

            string[] ownedBooks = new string[10];
            //Här slumpas ut antal böcker som en kund har, sedan slumpas namnet av vardera bok i for loopen
            int numberOfBooks = generator.Next(10);

            for (int i = 0; i < numberOfBooks; i++)
            {
                
            }

            return ownedBooks;
        }
    }
}
