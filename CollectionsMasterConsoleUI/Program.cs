using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        private static object MynumberList;

        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50  -------DONE
            var Mynumbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(Mynumbers);

            //TODO: Print the first number of the array  ---------DONE
            Console.WriteLine($"{Mynumbers[0]}");

            //TODO: Print the last number of the array   -------------DONE         
            Console.WriteLine($"{Mynumbers[Mynumbers.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists  -----------DONE
            NumberPrinter(Mynumbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); ----------------DONE
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇) --------------DONE
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(Mynumbers);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers  ----------DONE
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(Mynumbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now ____________________DONE
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");


            Array.Sort(Mynumbers);
            NumberPrinter(Mynumbers);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List    ---------------------------------DONE

            var MynumberList = new List<int>();

            //TODO: Print the capacity of the list to the console  ----------------------DONE

            Console.WriteLine($"Capacity: {MynumberList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(MynumberList);

            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity:  {MynumberList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            int MyUserNumber;
            bool isANumber;

            do
            {
                Console.WriteLine("What number will you search for in the number List?");
                isANumber = int.TryParse(Console.ReadLine(), out MyUserNumber);

            } while (isANumber == false);

            NumberChecker(MynumberList, MyUserNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists

            NumberPrinter(MynumberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            EvenKiller(MynumberList);
            MynumberList.Sort();
            NumberPrinter(MynumberList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            var myArray = MynumberList.ToArray();
            //TODO: Clear the list

            MynumberList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] Mynumbers)
        {
            for (int i = 0; i < Mynumbers.Length; i++)
            {
                if (Mynumbers[i] % 3 == 0)
                {
                    Mynumbers[i] = 0;
                }
            }
            NumberPrinter(Mynumbers);
        }

        private static void EvenKiller(List<int> MynumberList)
        {
            for (int i = MynumberList.Count - 1; i < -1; i--)
                
            {
                if (MynumberList[i] % 2 !=0)
                {

                    MynumberList.RemoveAt(i);
                }
            }

            var odds = MynumberList.Where(x => x % 2 != 0);
            NumberPrinter(MynumberList);
        }

        private static void NumberChecker(List<int> MynumberList, int searchNumber)
        {
            if (MynumberList.Contains(searchNumber))

            { 
                Console.WriteLine($"That's correct! You got Shelia, you're on your way to the bag!");

            }
            
           
            {
                Console.WriteLine($"These aren't the droids you're looking for");
                Console.WriteLine($"....These aren't the droids we're looking for");
            }
            
        }

        private static void Populater(List<int> MynumberList)
        {
            while (MynumberList.Count < 51)
            {


                Random rng = new Random();
                var Mynumbers = rng.Next(0, 50);

                MynumberList.Add(Mynumbers);
            }
        }

        private static void Populater(int[] Mynumbers)
        {
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            //that are between 0 and 50

            for (int i = 0; i < Mynumbers.Length; i++)
            {

                Random rng = new Random();
                Mynumbers[i] = rng.Next(0, 50);
            }

        }


        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);

            NumberPrinter(array);
        }


        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>

        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

        }


 
    }


}






