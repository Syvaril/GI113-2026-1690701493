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

            const int MaxLevel = 10;

            var bossName = "Kirin";
            var rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Boss Stats
            Console.WriteLine("==== KIRIN SAVE CONVERTER ====");
            Console.WriteLine($"NAME: {bossName}" +
                $"\nRANK: {rank}" +
                $"\nLEVEL: {level} / {MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nATTACK POWER: {attackPower}" +
                $"\nCRIT MULTIPLIER: {critMultiplier}" +
                $"\nIS BOSS: {isBoss}");

            // Implicit  conversion HP (int) -->> double
            Console.WriteLine("\n---- Implicit Conversion: HP as double ----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // Calculate Percent as double
            Console.WriteLine("\n---- Exact HP Percent (no integer truncation) ----");
            double HpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {HpPercentExact}%");

            // Explicit casting attack power (float) -->> int
            Console.WriteLine("\n---- Explicit Cast: Attack Power -> Display Int ----");
            int AttackPowerExplicit = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {AttackPowerExplicit}");

            // Cast vs. Convert: Crit Multiplier
            Console.WriteLine("\n---- Cast Vs Convert: Crit Multiplier ----");
            int CritCast = (int)critMultiplier;
            Console.WriteLine($"Crit Multiplier (int cast): {CritCast}");
            int CritConvert = (int)Math.Round(critMultiplier);
            Console.WriteLine($"Crit Multiplier (Convert rounded): {CritConvert}");


        }
    }
}
