using System;

namespace Prov1
{
    public class Books
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();

        public Books(){
           actualValue = generator.Next(1000);

           rarity = generator.Next(1, 4);

           PrintInfo();
        }

        public void PrintInfo(){

            Console.WriteLine(GetName());

            Console.WriteLine(rarity);

            Console.WriteLine(GetCategory());

            Console.WriteLine(Evaluate());
        }

        public int Evaluate(){
            
            int i = actualValue * rarity;
            //här slumpas priset ut antingen blir priset 50% mindre, samma eller 50% större, utfall 2 är då samma
            int j = generator.Next(1, 3);

            if(j == 1) {
                i = i / 2;
            }
            //i blir 150% 
            else if (j == 3) {
                i = i * 3/2;
            }

            return i;
        }

        public string GetCategory(){

            int chooseCatergory = generator.Next(1, 4);

            if(chooseCatergory == 1){

                return "magic";
            }

            else if(chooseCatergory == 2){

                return "religios";
            }

            else if(chooseCatergory == 3){

                return "ancient";
            }

            else if(chooseCatergory == 4){

                return "cooking recepies";
            }

            return "bababoey";
        }

        public string GetName(){
            
            string[] books = {"Bibeln 2: Potatis-Moses återkomst"};

            int randomBook = generator.Next(books.Length);

            return books[randomBook];
        }

        public bool IsCursed(){
            return false;
        }
    }
}
