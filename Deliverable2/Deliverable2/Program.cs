using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, What Are you in the Mood For?");
            Console.WriteLine("Here are your options: " +
                " 1) Action" +
                " 2) Chill Times" +
                " 3) Danger " +
                " 4) Good Food");

           int mood = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many people are you bringing with you?");

            int people = Convert.ToInt32(Console.ReadLine());

            if (mood == 1 && people <= 0)
            {
                Console.WriteLine("Okay, if you are in the mood for Action then you should go Stock Car Racing & travel in Sneakers ");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 1 && 1 <= people && people <= 4)
            {
                Console.WriteLine("Okay, if you are in the mood for Action then you should go Stock Car Racing & travel in a Sedan");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 1 && 5 <= people && people <= 10)
            {
                Console.WriteLine("Okay, if you are in the mood for Action then you should go Stock Car Racing & travel in a Volkswagon Bus");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 1 && 10 <= people)
            {
                Console.WriteLine("Okay, if you are in the mood for Action then you should go Stock Car Racing & travel in a plane");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 2 && people <= 0)
            {
                Console.WriteLine("Okay, if you are in the mood for Chilling  then you should go Hiking & travel in Sneakers ");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 2 && 1 <= people && people <= 4)
            {
                Console.WriteLine("Okay, if you are in the mood for Chilling  then you should go Hiking & travel in a Sedan");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 2 && 5 <= people && people <= 10)
            {
                Console.WriteLine("Okay, if you are in the mood for Chilling  then you should go Hiking & travel in a Volkswagon Bus");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 2 && 10 <= people)
            {
                Console.WriteLine("Okay, if you are in the mood for Chilling  then you should go Hiking & travel in a plane");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 3 && people <= 0)
            {
                Console.WriteLine("Okay, if you are in the mood for Danger  then you should go Skydiving  & travel in Sneakers ");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 3 && 1 <= people && people <= 4)
            {
                Console.WriteLine("Okay, if you are in the mood for Danger  then you should go Skydiving  & travel in a Sedan");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 3 && 5 <= people && people <= 10)
            {
                Console.WriteLine("Okay, if you are in the mood for Danger  then you should go Skydiving & travel in a Volkswagon Bus");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 3 && 10 <= people)
            {
                Console.WriteLine("Okay, if you are in the mood for Danger  then you should go Skydiving & travel in a plane");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 4 && people <= 0)
            {
                Console.WriteLine("Okay, if you are in the mood for Good Food  then you should go to Taco Bell & travel in Sneakers ");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 4 && 1 <= people && people <= 4)
            {
                Console.WriteLine("Okay, if you are in the mood for Good Food  then you should go to Taco Bell  & travel in a Sedan");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 4 && 5 <= people && people <= 10)
            {
                Console.WriteLine("Okay, if you are in the mood for Good Food  then you should go to Taco Bell & travel in a Volkswagon Bus");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood == 4 && 10 <= people)
            {
                Console.WriteLine("Okay, if you are in the mood for Good Food  then you should go to Taco Bell & travel in a plane");
                Console.WriteLine("Goodbye!!");
            }

            else if (mood != 1 && mood != 2 && mood != 3 && mood != 4)
                    Console.WriteLine("You have entered an invalid entry for your mood, please select a number beween 1 and 4");

            Console.WriteLine();






        }
    }
            }
