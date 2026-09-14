/*
* Student ID : 1690701493
* Name       : Thanonchai Kruttha
* Section    : 129B
* No.        : NA
* Course     : GI113 Computer Programming (GI)
*/



using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {



                var GameName = "Pokemon Sword And Shield: The Crown Tundra";
                var monName = "Calyrex";
                string monVariant = "Ice Rider";
                string monPrimaryType = "Psychic";
                string monSecondaryType = "Ice";
                int monLevel = 80;
                string monNature = "Adamant";
                string monHeldItem = "Leftovers";
                string monAbility = "As One";
                float monHeight = 2.4f;
                float monWeight = 809.1f;
                bool isEscapeable = false;
                char monRarity = 'S';

                // Moveset

                string Slot1Move = "Glacial Lance";
                string Slot2Move = "Sword Dance";
                string Slot3Move = "Zen Headbutt";
                string Slot4Move = "Close Combat";

                Console.WriteLine($"==== {GameName} ====");
                Console.WriteLine($"Pokemon Name: {monName}");
                Console.WriteLine($"Variant: {monVariant}");
                Console.WriteLine($"Type: {monPrimaryType} / {monSecondaryType}");
                Console.WriteLine($"Level: {monLevel}");
                Console.WriteLine($"Nature: {monNature}");
                Console.WriteLine($"Held Item: {monHeldItem}");
                Console.WriteLine($"Ability: {monAbility}");
                Console.WriteLine($"Height: {monHeight} m");
                Console.WriteLine($"Weight: {monWeight} kg");
                Console.WriteLine($"Escapeable: {isEscapeable}");
                Console.WriteLine($"Rarity: {monRarity}");
                Console.WriteLine("Moveset:");
                Console.WriteLine($"1. {Slot1Move}");
                Console.WriteLine($"2. {Slot2Move}");
                Console.WriteLine($"3. {Slot3Move}");
                Console.WriteLine($"4. {Slot4Move}");






            }
        }
    }
}
