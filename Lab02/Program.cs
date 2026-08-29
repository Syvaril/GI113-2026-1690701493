/*
 * Student ID : 1690701493
 * Name       : Thanonchai Kruttha
 * Section    : 129B
 * No.        : NA
 * Course     : GI113 Computer Programming (GI)
 */

using System;
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Part A
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("==== BOSS STATUS: INITIAL ====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;

            Console.WriteLine();

            Console.WriteLine("==== BOSS STATUS: AFTER DAMAGE ====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            // Part B
            {
                string monsterName = "Sandorah";
                int lvl = 21;
                int baseHp = 115;
                float physATK = 25.5f;
                double dmgMultiplier = 1.75;

                Console.WriteLine("==== MONSTER 1 ====");
                Console.WriteLine($"Name: {monsterName}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"HP: {baseHp}");
                Console.WriteLine($"Physical Attack: {physATK}");
                Console.WriteLine($"Damage Multiplier: {dmgMultiplier}");

                Console.WriteLine();
            }

            {
                string monsterName = "Gohdorah";
                int lvl = 67;
                int baseHp = 670;
                float physATK = 67.5f;
                char difficultytier = 'B';

                Console.WriteLine("==== MONSTER 2 ====");
                Console.WriteLine($"Name: {monsterName}");
                Console.WriteLine($"Level: {lvl}");
                Console.WriteLine($"Difficulty Tier: {difficultytier}");
                Console.WriteLine($"HP: {baseHp}");
                Console.WriteLine($"Attack Power: {physATK}");

                Console.WriteLine();
            }

            {
                string monsterName = "Nightcrawler";
                int lvl = 82;
                int baseHp = 1350;
                float physATK = 120.5f;
                bool IsAwakened = true;

                Console.WriteLine("==== MONSTER 3 ====");
                Console.WriteLine($"Name: {monsterName}");
                Console.WriteLine($"Level: {lvl}");
                Console.WriteLine($"HP: {baseHp}");
                Console.WriteLine($"Attack Power: {physATK}");
                Console.WriteLine($"Awakened: {IsAwakened}");

                Console.WriteLine();
            }

            {
                string monsterName = "Naerotiv";
                int lvl = 130;
                int baseHp = 2300;
                float specialAtk = 200.5f;
                string monsterPassive = "Petal in The Wind";

                Console.WriteLine("==== MONSTER 4 ====");
                Console.WriteLine($"Name: {monsterName}");
                Console.WriteLine($"Level: {lvl}");
                Console.WriteLine($"HP: {baseHp}");
                Console.WriteLine($"Attack Power: {specialAtk}");
                Console.WriteLine($"Passive: {monsterPassive}");

                Console.WriteLine();
            }

        }
    }
}

