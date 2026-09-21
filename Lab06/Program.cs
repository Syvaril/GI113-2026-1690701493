/*
* Student ID : 1690701493
* Name       : Thanonchai Kruttha
* Section    : 129B
* No.        : NA
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            bool isPoisoned = false;
            if (isPoisoned) { }
            if (!isPoisoned) { }

            bool hasKey = true;
            Console.WriteLine("Your Level (1-99):   ");
            bool LvlInput = int.TryParse(Console.ReadLine(), out int level);

            if (!LvlInput || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid level.");

            }
            else if (level >= 10 || hasKey)
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                if (hasKey == true)
                {
                    Console.WriteLine("The door opens.");
                }

                else
                {
                    Console.WriteLine("The door stays shut.");

                }
            }
            else
            {
            }
            */

            var GameName = "Pokemon Sword And Shield";
            string Hero = "Zacian";
            string Monster = "Eternatus";
            string HeroAbility = "Intrepid Sword";
            float DamageMultiplier = 1.5f;
            int heroHp = 230;
            int heroAtk = 10;
            int monHp = 570;
            int potionHeal = 50;

            Console.WriteLine($"GAME TITLE: {GameName}");
            Console.WriteLine($"A WILD {Monster} HAS APPEARED...");
            Console.WriteLine($"{Hero} ABILITY BOOSTED IT'S ATTACK BY 1 STAGE");
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: DRINK HP POTION");

            Console.WriteLine("CHOOSE YOUR ACTION (1 - 2): ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isInputValid == false || choice < 1 || choice > 2)
            {
                Console.WriteLine("Invalid Input, Enter between 1 - 2.");
            }
            else if (choice == 1)
            {
                monHp -= heroAtk;
                if (monHp < 0)
                {
                    int damage = (int)Math.Round(heroAtk * DamageMultiplier);
                    Console.WriteLine($"{Hero} attacked the monster! with {damage} damage. The monster's HP is now {monHp} HP left.");
                }
                else if (choice == 2)
                {
                    monHp += potionHeal;
                    Console.WriteLine($"{Hero} drank a potion! {Hero} healed {potionHeal} HP. The m");
                }
            }
        }
    }
}
    
