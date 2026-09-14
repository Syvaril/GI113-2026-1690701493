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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            {



                var GameName = @"                                                     █▓▓▓                                           
                                                   ▓▓▓▓▓▓▓                                          
                                                  ▓▓▓▒░▒▒▓▓▓                                        
                                   ▓▓▓▓▓▓▓▓     ▓▓▓▓▒▒▓▓▓▓▓        ▓▓▓▓▓▓▓▓                         
      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓       █▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ███▓▓▓▓▓▓▓▓  ▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓     █▓▓▓▓▓              
  ▓▓▓▓▓▓▒▒▒▒▒░░▒▒▒▒▒▓▓▓▓    ██▓▓▒▒░░▒▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▒▒▒▓▓▓▓▓█▓▒▒▒▒▒▓▓▒░▒▒▓▓     █▓▓▓▓▓▓▓▓▓▓▓▓▓      
█▓▓▓▒▒░░░░░░░░░░░░░░▒▒▓▓▓   ▓▓▓▓▓▒░░▒▒▓▒░░░░▒▓▓▓▒░░▒▒▒░░▒▒▓▓▓▓▒░░░▒▒▒▒░░▒▓▓     ▓▓▓▓▒░▒▒▒▓▓▓▓▓▓▓▓▓▓▓
██▓▓▓▒░░░░░░░░▒▒▒▒▒░░▒▒▓▓   ▓▓▓█▓▒▒░▒▒▒░░░░▒▓▓▓▒░▒▓▓▓▓▒░▒▓▓▓▓▓▒░░░▒▒▒░░░▒▓▓▓▓▓▓▓▓▓▓▓▒░░░▒▒▓▓▓▒░▒▒▓▓▓
 ██▓▓▓▒▒▒░░░░░▒▓▓▓▓▓░▒▒▓▓▓▓▓▓▓▓▓▓▓▒░░░░░░▒▓▓▓▓▒░▒▓▓▓▓▒▒▓▓▓▓▓▓▓▒░░░░░░░░░▒▒▓▓▓▒▒▒▒▒▒▓▓▒░░░▒▓▓▒░░░▒▓▓ 
  ▓▓▓▓▓▓▓▒░░░░▒▒▓▓▓▓░▒▓▓▓▒▒▒▓▒░▒▒▓▓░░░░░▒▓▓▓▓▓▓░░▒▓▒░▒▓▒░▒▒▓▓▓▒░░░░░░░░░▒▓▒░▒▓▒░░▒▒▒▓▓▒░░▒▒▓▒░░▒▓▓▓ 
   ▓▓▓▓▓▓▓▒░░░░▒▓▓▒░▒▓▓▒▒▒▓▓▒░▒▒▒▒▓▓░░░░░▒▒▒▒▓▓▒▒░░░░░░░░░▒▓▓▓▒░▒▓▒░░▒▒▒▓▒▒▒▒▓▓▓▓▓▒▒▒▓▒▒░░▒▒░░░▒▓▓  
      ██▓▓▓▒░░░░▒▒▒▓▓▓▒▒░▒▓▓▓▓▓▓▒▒▓▓░▒▓▓▒▒░░░▒▒▓▓▓▒▒▒▒▒▓▓▓▓▓▓░░░▒▓▓▒▒▓▒▒▓▒░░▒▒▒▒▒▒░▒▓▓▒▒▒░▒░░░▒▓▓▓  
       ███▓▓▒░░░▒▓▓▓▓▓▒░░░▒▒▒▒░░░▒▓▒░▒▓▓▓▓▓▓▒░░▒▒▒▓▓▓▓▓▓██▓▓▒▒░░▒▓▓▓▓▓▓▒▓▓▒░░░░░░░▒▓▓▒▒▒▒░░░░▒▓▓▓   
        ███▓▓▒░░▒▒▓▓▓▓▓▒░░░░░░░▒▒▓▓░░▒▓▓███▓▓▓▓▒▒░░▒▓▓  ██▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒▒▒▓▓▒▒░▒▓▒░░░▒▒▓▓    
         ███▓▒▒░░▒▓▓▓█▓▓▓▒░░░▒▓▓▓▓▓░░▒▓▓   ████▓▓▓▓▓▓▓     ██████████▓▓▓▒▒▒▓▓▓▓▓█▓▓▒░░▒▓▒░░░▒▓▓     
          ██▓▓▒░░▒▒▓▓▓███▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓       ████▓▓▓             ████▓▓▓▓▓▓▓ ██▓▓▓▓▓▓▓▒░░▒▓▓▓     
           ██▓▓▒░░▒▓▓▓  ████   ▓████               ██                   ██████  ███████▓▒▒░▒▓▓      
           ███▓▓▓▓▓▓▓▓                                                               ███▓▓▓▓▓▓      
            ██████                                                                      █████        ";


                var monName = "Calyrex";
                var monRegion = "Galar";

                string monVariant = "Ice Rider";
                string monPrimaryType = "Psychic";
                string monSecondaryType = "Ice";
                int monLevel = 80;
                string monNature = "Adamant";
                string monHeldItem = "Leftovers";
                string monAbility = "As One";
                float monHeight = 2.4f;
                float monWeight = 809.1f;
                double monCatchRate = 95.7;
                bool isEscapeable = false;
                char monRarity = 'S';
                int monDexNumber = 898;
                int monBaseStatTotal = 680;

                // implicit Conversion
                double baseStatTotalDouble = monBaseStatTotal;

                // explicit Cast vs Convert.ToInt32()
                int castResult = (int)monCatchRate;
                int convertResult = Convert.ToInt32(monCatchRate);

                // moveset

                string slot1Move = "Glacial Lance";
                string slot2Move = "Sword Dance";
                string slot3Move = "Zen Headbutt";
                string slot4Move = "Close Combat";

                Console.WriteLine($"{GameName}");
                Console.WriteLine();
                Console.WriteLine($"╔══════════════════════════════════════════════════╗");
                Console.WriteLine($"║ {"------------------- POKEDEX -------------------",-48} ║");
                Console.WriteLine($"║                                                  ║");
                Console.WriteLine($"║ {"Pokedex Number:",-17} #{monDexNumber,-29} ║");
                Console.WriteLine($"║ {"Pokemon Name:",-17} {monName,-30} ║");
                Console.WriteLine($"║ {"Variant:",-17} {monVariant,-30} ║");
                Console.WriteLine($"║ {"Region:",-17} {monRegion,-30} ║");
                Console.WriteLine($"║ {"Type:",-17} {monPrimaryType} / {monSecondaryType,-20} ║");
                Console.WriteLine($"║ {"Level:",-17} {monLevel,-30} ║");
                Console.WriteLine($"║ {"Nature:",-17} {monNature,-30} ║");
                Console.WriteLine($"║ {"Held Item:",-17} {monHeldItem,-30} ║");
                Console.WriteLine($"║ {"Ability:",-17} {monAbility,-30} ║");
                Console.WriteLine($"║ {"Height:",-17} {monHeight} M{"",-25} ║");
                Console.WriteLine($"║ {"Weight:",-17} {monWeight} KG{"",-22} ║");
                Console.WriteLine($"║ {"Escapeable:",-17} {isEscapeable,-30} ║");
                Console.WriteLine($"║ {"Rarity:",-17} {monRarity,-30} ║");
                Console.WriteLine($"║                                                  ║");
                Console.WriteLine($"╠══════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {"-------------------- MOVES ---------------------",-48} ║");
                Console.WriteLine($"║                                                  ║");
                Console.WriteLine($"║ {"1.",-4} {slot1Move,-43} ║");
                Console.WriteLine($"║ {"2.",-4} {slot2Move,-43} ║");
                Console.WriteLine($"║ {"3.",-4} {slot3Move,-43} ║");
                Console.WriteLine($"║ {"4.",-4} {slot4Move,-43} ║");
                Console.WriteLine($"║                                                  ║");
                Console.WriteLine($"╠══════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {"----------------- CONVERSION -------------------",-48} ║");
                Console.WriteLine($"║                                                  ║");
                Console.WriteLine($"║ {"BaseStat as Double:",-20} {baseStatTotalDouble,-27} ║");
                Console.WriteLine($"║ {"Cast (int):",-20} {castResult,-27} ║");
                Console.WriteLine($"║ {"Convert.ToInt32():",-20} {convertResult,-27} ║");
                Console.WriteLine($"║                                                  ║");
                Console.WriteLine($"╚══════════════════════════════════════════════════╝");

            }
        }
    }
}
