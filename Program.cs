using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 5;
            int y = 10;

            int z = x + y;

            Console.WriteLine(z);

            double a = 1.5;
            double b = 0.4;

            double c = a * b;

            Console.WriteLine(c);

            string name = "Karl";
            string x1 = "5";

            char d = 'a';
            char e = 'b';

            bool isStudying = true;
            bool isWorking = false;

            bool boolValue1 = isStudying && isWorking;
            Console.WriteLine(boolValue1);

            bool boolValue2 = isStudying || isWorking;
            Console.WriteLine(boolValue2);





            int h = 20;
            if (h > 0)
            {
                Console.WriteLine("Positive number");
            }
            else if (h < 0)
            {
                Console.WriteLine("Negative number");
            }
            else
            {
                Console.WriteLine("Zero");
            }

            
            //skajdkasjkldkl kasdklj alksj dkldssss



            int s = 30;

            switch (s)
            {
                case 20:
                    Console.WriteLine("Number Twenty");
                    break;

                case 30:
                    Console.WriteLine("Number Thirty");
                    break;

                case 40:
                    Console.WriteLine("Number Forty");
                    break;
            }




            int[] numbers = { 1, 0, -2, 10 };
            List<int> numberList = new List<int> { 1, 0, -2, 10 };
            numberList.Add(5);

            int firsNumber = numbers[0];
            Console.WriteLine(firsNumber);

            int firstListElement = numberList[0];
            Console.WriteLine(firstListElement);

            int element = numberList[4]; //Lisasime viienda elemendi
            Console.WriteLine(element);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            for (int i = 0; i < numberList.Count - 1; i++)
            {
                Console.WriteLine(numberList[i]);
            }



            int index = 0;
            while (index < numberList.Count)
            {
                Console.WriteLine(numberList[index]);
                index++;
            }


            Food sweets = new Food("sweet", 5);
            Console.WriteLine(sweets.Name);
            Console.WriteLine(sweets.Price);

            sweets.Price = 8;
            Console.WriteLine(sweets.Price);

            Food jook = new Food("Vesi", 2);
            Food kala = new Food("Ahven", 1);

            Console.WriteLine(jook.Name + "," + jook.Price);

            Food[] groceries = { sweets, jook, kala };
            Console.WriteLine(groceries[1].Name);

            ShoppingCart myCart = new ShoppingCart();
            myCart.AddToCart(jook, 4);
            myCart.AddToCart(kala, 3);

            Console.WriteLine(myCart.Sum);

            DetailedShoppingCart cart = new DetailedShoppingCart();
            cart.AddToCart(jook, 43);
            cart.AddToCart(sweets, 8);

            cart.Calculate();
        }
    }
}


