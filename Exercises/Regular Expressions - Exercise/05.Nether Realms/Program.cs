using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"[^,|\s]+";
            string healthPattern = @"[^0-9\+\-\*\/\.]";
            string damagePattern = @"(\+*\-*[0-9]+\.*[0-9]*)";
            string damageFactorPattern = @"[*\/]";

            string input = Console.ReadLine();

            MatchCollection names = Regex.Matches(input, namePattern);
            
            foreach (Match name in names.OrderBy(x => x.Value))
            {
                MatchCollection healthChars = Regex.Matches(name.Value, healthPattern);

                int health = 0;

                foreach (Match healthChar in healthChars)
                {
                    health += char.Parse(healthChar.Value);
                }


                MatchCollection damageNumbers = Regex.Matches(name.Value, damagePattern);

                double damage = 0;

                foreach (Match damageNumber in damageNumbers)
                {
                    damage += double.Parse(damageNumber.Value);
                }

                if (damage != 0)
                {
                    MatchCollection damageFactors = Regex.Matches(name.Value, damageFactorPattern);

                    foreach (Match damageFactor in damageFactors)
                    {
                        if (damageFactor.Value == "*")
                        {
                            damage *= 2;
                        }
                        else
                        {
                            damage /= 2;
                        }
                    }

                }

                Console.WriteLine($"{name.Value} - {health} health, {damage:F2} damage");
            }
        }
    }
}
