using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personality test
            //приложение просит пользователя ввести его любимый цвет
            //на основе введённого значения, консоль показывает пользователя некоторую обратную связь
            //red - you are so romantic
            //blue - you are workaholic
            //grenn - you care about the enviroment
            //любое другое значение, то консоль выведет предложение " you are a {userInput} unicorn"

            Console.WriteLine("Please enter your favorit color");
            string userInput = Console.ReadLine().ToLower(); //RED/Red/reD/rEd/rdE --> red

            if(userInput == "red")
            {
                Console.WriteLine("You are so romantic.");
            }
            
                else if(userInput == "blue")
                {
                    Console.WriteLine("you are workaholic.");
                }
            else if (userInput == "green")
            {
                Console.WriteLine("you care about the enviroment.");


            }
            {
                Console.WriteLine($"You are {userInput} unicorn");
            }
            Console.WriteLine("Have a nice day");
            }
        }
    }

