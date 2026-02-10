using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Game_4__ISA_sim_
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayMusic();
            Test test = new Test();
            string name = "Isa";
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("you need to go and make friends");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey(); //waits for any key press
            Console.Clear(); //clears the console

            Console.WriteLine("you need to choose where to go");
            Console.WriteLine("1. School");
            Console.WriteLine("2. Park");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You went to school");
                School();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You went to the park, and its raining no ones there");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please restart the game.");
            }

        }

        static void School()
        {
            PlayMusic();
            Console.WriteLine("At school, you see many students.");
            Console.WriteLine("Do you want to approach someone?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("You see a student reading and a student on his phone.");
                Console.WriteLine("Who do you want to approach?");
                Console.WriteLine("1. Student reading");
                Console.WriteLine("2. Student on the phone");
                string studentChoice = Console.ReadLine();
                if (studentChoice == "1")
                {
                    PlayMusic();
                    Console.WriteLine("You approached the student reading.");
                    Console.WriteLine("The students name is Sobhi.");
                    Console.WriteLine("1. Ask what is he reading.");
                    Console.WriteLine("2. Start a conversation about school.");
                    Console.WriteLine("3. Start a conversation about girls");
                    string convoChoice = Console.ReadLine();
                    if (convoChoice == "1")
                    {
                        Console.WriteLine("Sobhi reads for the test! You forgot you had test.");
                        Console.WriteLine("1. Ask for help");
                        Console.WriteLine("2. Go Study");
                        string convoChoice2 = Console.ReadLine();
                        if (convoChoice2 == "1")
                        {
                            Console.WriteLine("Sobhi is happy to help you! You both become friends.");
                            GymDay();
                        }
                        else if (convoChoice2 == "2")
                        {
                            Console.WriteLine("You decided to study on your own. You missed the opportunity to make friends.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. You missed the opportunity to make friends.");
                        }
                    }
                    else if (convoChoice == "2")
                    {
                        PlayMusic();
                        Console.WriteLine("Sobhi likes the libary in school! You both become friends.");
                        GymDay();
                    }
                    else if (convoChoice == "3")
                    {

                        Console.WriteLine("Sobhi is not interested in that topic. You didn't make a connection.");
                    }
                }
                else if (studentChoice == "2")
                {
                    Console.Clear();
                    PlayMusic();
                    Console.WriteLine("You approached the student on the phone.");
                    Console.WriteLine("The students name is Alex.");
                    Console.WriteLine("1. Start a conversation about video games.");
                    Console.WriteLine("2. Start a conversation about school.");
                    Console.WriteLine("3. Start a conversation about girls");
                    string convoChoice = Console.ReadLine();
                    if (convoChoice == "1")
                    {
                        Console.WriteLine("Alex loves video games! You both become friends.");
                        SecondDay();
                    }
                    else if (convoChoice == "2")
                    {
                        Console.WriteLine("Alex finds school boring like you. You both become friends.");
                        SecondDay();
                    }
                    else if (convoChoice == "3")
                    {
                        Console.WriteLine("Alex is not interested in that topic. You didn't make a connection.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. You missed the opportunity to make friends.");
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You decided not to approach anyone. Maybe next time. Restart the game.");


                }
            }
        }

        static void GymDay()
        {
            Console.Clear();
            PlayMusic();
            Console.WriteLine("You have 1 friend");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Day 2: you are in the gym");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Do you want to invite your friend Sobhi?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                PlayMusic();
                Console.WriteLine("Sobhi came the gym.");
                Console.WriteLine("Sobhi is happy to see you! You both have a great time working out together.");
                Console.WriteLine("Build your way to a stronger conection");
                Console.WriteLine("1. ask Sobhi about hes hobbis.");
                Console.WriteLine("2. ask Sobhi about hes favorit movie.");
                string convoChoice = Console.ReadLine();
                if (convoChoice == "1")
                {
                    PlayMusic();
                    Console.Clear();
                    Console.WriteLine("Sobhi loves to play soccer!.");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("Sobhi asks you about your hobbis");
                    Console.WriteLine("1. I like to play soccer too!");
                    Console.WriteLine("2. I like to play video games.");
                    string convoChoice2 = Console.ReadLine();
                    if (convoChoice2 == "1")
                    {
                        PlayMusic();
                        Console.WriteLine("Sobhi is excited to find out you also like soccer!.");
                        Console.WriteLine("Congratulations! You are on your way to building strong friendships.");
                        End();
                    }
                    else if (convoChoice2 == "2")
                    {
                        PlayMusic();
                        Console.WriteLine("Sobhi is not interested in video games. You didn't make a stronger connection.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. You missed the opportunity to make a stronger connection.");
                    }
                }
                else if (convoChoice == "2")
                {
                    Console.Clear();
                    PlayMusic();
                    Console.WriteLine("Sobhi loves the movie Inception!.");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("Sobhi asks you about your favorite movie");
                    Console.WriteLine("1. I like The Dark Knight!");
                    Console.WriteLine("2. I like White checks.");
                    string convoChoice2 = Console.ReadLine();
                    if (convoChoice2 == "1")
                    {
                        PlayMusic();
                        Console.WriteLine("Console.WriteLine(\"Sobhi likes your choice in movies");
                        Console.WriteLine("Congratulations! You are on your way to building strong friendships.");
                        End();
                    }
                    else if (convoChoice2 == "2")
                    {
                        PlayMusic();
                        Console.WriteLine("Sobhi likes your choice in movies");
                        Console.WriteLine("Congratulations! You are on your way to building strong friendships.");
                        End();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. You missed the opportunity to make a stronger connection.");
                    }
                }

            }

            else if (choice == "2")
            {
                PlayMusic();
                Console.WriteLine("You decided not to Invite Sobhi. Maybe next time. Restart the game.");
            }





        }


        static void SecondDay()
        {
            Console.Clear();
            Console.WriteLine("You have 1 friend");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Day 2: you are in a cafe");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Do you want to invite your friend Alex?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Alex came the cafe.");
                Console.WriteLine("Alex is happy to see you!.");
                Console.WriteLine("Build your way to a stronger conection");
                Console.WriteLine("1. ask Alex about hes favorit game.");
                Console.WriteLine("2. ask Alex about hes favorit movie.");
                string convoChoice = Console.ReadLine();
                if (convoChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Alex Likes Minecraft.");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("Alex asks you about your hobbis");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("1. I like to read books!");
                    Console.WriteLine("2. I like to play video games.");
                    string convoChoice2 = Console.ReadLine();
                    if (convoChoice2 == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Alex find it a bit boaring!.");
                        Console.WriteLine("make a choice fast.");
                        Console.WriteLine("1. change subject");
                        Console.WriteLine("2. panic and kill him!");
                        string convoChoice3 = Console.ReadLine();
                        if (convoChoice3 == "1")
                        {
                            Console.WriteLine("Alex is happy to change the subject!.");
                            Console.WriteLine("Congratulations! You are on your way to building strong friendships.");
                            End();
                        }
                        else if (convoChoice3 == "2")
                        {
                            Console.WriteLine("You sick bastard.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. You missed the opportunity to make a stronger connection.");
                        }


                    }
                    else if (convoChoice2 == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Sobhi is interested in video games.");
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Congratulations! You are on your way to building strong friendships.");
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. You missed the opportunity to make a stronger connection.");
                    }
                }
                else if (convoChoice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Alex loves the movie Inception!.");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("Alex asks you about your favorite movie");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("1. I like The Dark Knight!");
                    Console.WriteLine("2. I like White checks.");
                    string convoChoice2 = Console.ReadLine();
                    if (convoChoice2 == "1")
                    {
                        Console.WriteLine("Console.WriteLine(\"Alex likes your choice in movies");
                        Console.WriteLine("Congratulations! You are on your way to building strong friendships.");
                        End();
                    }
                    else if (convoChoice2 == "2")
                    {
                        Console.WriteLine("Alex likes your choice in movies");
                        Console.WriteLine("Congratulations! You are on your way to building strong friendships.");
                        End();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. You missed the opportunity to make a stronger connection.");
                    }
                }

            }

            else if (choice == "2")
            {
                Console.WriteLine("You decided not to Invite Sobhi. Maybe next time. Restart the game.");
            }
        }
        static void End()
        {   
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("You learnd how to make a friend and how to build a stronger conection");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Congratulations! You have completed the game.");
            Console.WriteLine("now you can go out and make friends in real life!");
        }

        static void PlayMusic()
        {
            int[] notes = { 800, 1000, 1200, 1000, 800 };
            int duration = 200;

            foreach (int note in notes)
            {
                Console.Beep(note, duration);
            }
        }

    }
}
