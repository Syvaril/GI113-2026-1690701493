/*
* Student ID : 1690701493
* Name       : Thanonchai Kruttha
* Section    : 129B
* No.        : NA
* Course     : GI113 Computer Programming (GI)
*/


using System;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Damage Calculator
                Console.WriteLine("=== BATTLE DAMAGE CALCULATOR ===");
                Console.WriteLine("Hero vs Monster -- scouting the fight before it happens");

                Console.Write("Hero HP: ");
                bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
                Console.Write("Hero Attack: ");
                bool heroAttackOk = int.TryParse(Console.ReadLine(), out int heroAtk);
                Console.Write("Hero Defense: ");
                bool heroDefenseOk = int.TryParse(Console.ReadLine(), out int heroDef);
                Console.Write("Monster HP: ");
                bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
                Console.Write("Monster Attack: ");
                bool monsterAttackOk = int.TryParse(Console.ReadLine(), out int monAtk);
                Console.Write("Monster Defense: ");
                bool monsterDefenseOk = int.TryParse(Console.ReadLine(), out int monDef);
                bool allStatsValid = heroHpOk && heroAttackOk && heroDefenseOk && monsterHpOk && monsterAttackOk && monsterDefenseOk;
                Console.WriteLine($"All stats valid: {allStatsValid}");

                int monsterMaxHp = monsterHp;
                Console.WriteLine($"[Hero]    HP:{heroHp} ATK:{heroAtk} DEF:{heroDef}");
                Console.WriteLine($"[Monster] HP:{monsterHp} ATK:{monAtk} DEF:{monDef}");

                // heroHp += potionHeal
                
                int potionHeal = 8;
                heroHp += potionHeal;
                Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} HP, Hero HP is: {heroHp}");

                int normalDamage = Math.Max(0, heroAtk - monDef);
                Console.WriteLine($"Normal attack deals: {normalDamage} DMG");

                int powerDamage = Math.Max(0, heroAtk * 2 - monDef);
                Console.WriteLine($"Power attack deals: {powerDamage} DMG");

                int counterDamage = Math.Max(0, monAtk - heroDef);
                Console.WriteLine($"Counter attack deals: {counterDamage} DMG");

                Random randomSmth = new Random();
                int roll = randomSmth.Next(1, 70);
                bool isCrit = roll <= 10;
                int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; 
                Console.WriteLine($"Crit Damage roll: {roll} (Crit?: {isCrit})");
                Console.WriteLine($"If critical, normal attack would deal: {critDamage} DMG");



            }
        }
    }
}
