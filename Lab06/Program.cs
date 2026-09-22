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
            var GameName = "Pokemon Sword And Shield";
            string Hero = "Zacian";
            string Monster = "Clefairy";
            string HeroAbility = "Intrepid Sword";
            string HeroMoves = "Behemoth Blade";
            float DamageMultiplier = 1.5f;
            int heroHp = 180;
            int heroAtk = 100;
            int monHp = 1;
            int potionHeal = 50;

            Console.WriteLine($"[[--{GameName}--]]");
            Console.WriteLine();
            Console.WriteLine($"A Wild {Monster} Has Appeared!");
            Console.WriteLine();
            Console.WriteLine($"{Hero}'s Ability {HeroAbility} >>>");
            Console.WriteLine();
            Console.WriteLine($"{Hero}'s Attack Roses!");
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: DRINK HP POTION");
            Console.WriteLine("ACTION 3: RUN");
            Console.WriteLine("================================");
            Console.WriteLine();
            Console.WriteLine("CHOOSE YOUR ACTION (1 - 3): ");
            Console.WriteLine();
            bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isInputValid == false || choice < 1 || choice > 3)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Input, Enter between 1 - 3.");
            }
            else if (choice == 1)
            {
                int damage = (int)Math.Round(heroAtk * DamageMultiplier);
                monHp -= damage;

                Console.WriteLine();
                Console.WriteLine($"{Hero} Used {HeroMoves} Deals {damage} damage. {Monster}'s HP is now {monHp} HP left.");
                Console.WriteLine($"It's super effective! {Monster} is defeated!");
            }
            else if (choice == 2)
            {
                heroHp += potionHeal;

                Console.WriteLine();
                Console.WriteLine($"{Hero} drank a potion! {Hero} healed {potionHeal} HP. {Hero}'s HP is now {heroHp}.");
            }
            else if (choice == 3)
            {
                Console.WriteLine();
                Console.WriteLine($"You got away safely!");
            }
        }
    }
}