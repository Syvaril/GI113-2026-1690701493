/*
* Student ID : 1690701493
* Name       : Thanonchai Kruttha
* Section    : 129B
* No.        : NA
* Course     : GI113 Computer Programming (GI)
*/

using System;
using System.Runtime.CompilerServices;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {   //-- Character Creation logic

                Console.WriteLine("+------------------------------+");
                Console.WriteLine("|      CHARACTER CREATION       |");
                Console.WriteLine("+------------------------------+");
                Console.WriteLine("Name your character: ");
                string charName = Console.ReadLine();
                Console.Write("Choose a class (1 - 3) ");
                bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
                Console.Write("Starting luck (0.0-10.0): ");
                bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
                Console.WriteLine($"{charName} the Class--{classNum} adventurer enters the dungeon. Luck: {luck}");

            }

            {   //-- Difficulty logic

                Console.WriteLine("Choose difficulty (1-3): ");
                int difficulty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Difficulty set to {difficulty}");

            }

            {   //-- Item Shop Logic

                Console.WriteLine("+------------------------------+");
                Console.WriteLine("|          ITEM SHOP           |");
                Console.WriteLine("+------------------------------+");

                Console.WriteLine("How many potions? ");
                bool IsValid = int.TryParse(Console.ReadLine(), out int quantity);
                Console.WriteLine($"Valid input: {IsValid}");
                Console.WriteLine($"Quantity: {quantity}");

            }

            {  //-- Set Volume Logic

                Console.WriteLine("+------------------------------+");
                Console.WriteLine("|           SET VOLUME         |");
                Console.WriteLine("+------------------------------+");
                Console.WriteLine("Set volume (0.0-1.0): ");
                bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
                bool IsValid = volumeOk && volume >= 0.0 && volume <= 1.0;
                Console.WriteLine($"Valid input: {IsValid}");
                Console.WriteLine($"Volume: {volume}");

            }

            {  //-- New Save File Logic

                Console.WriteLine("+------------------------------+");
                Console.WriteLine("|         NEW SAVE FILE        |");
                Console.WriteLine("+------------------------------+");
                Console.WriteLine("Enter save name: ");
                string saveName = Console.ReadLine();
                Console.WriteLine("Choose save slot (1-3): ");
                bool slotOk = int.TryParse(Console.ReadLine(), out int saveSlot);
                Console.WriteLine($"Save name: {saveName}");
                bool IsValid = slotOk && saveSlot >= 1 && saveSlot <= 3;
                Console.WriteLine($"Valid input: {IsValid}");
                Console.WriteLine($"Slot: {saveSlot}");

            }




            }
        }
    }
