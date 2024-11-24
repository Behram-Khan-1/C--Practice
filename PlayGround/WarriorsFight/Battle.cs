
namespace Playground.WarriorsFight;

public class Battle
{
    static Random rand = new Random();
    

    public static void StartFight(Warriors warrior1, Warriors warrior2)
    {
       Console.WriteLine("Battle Started...");
        if(rand.Next(1, 3) == 1)
        {
            Console.WriteLine("Warrior 1 Initiates the fight...");
            while(warrior1.Health > 0 && warrior2.Health > 0)
            {
                Console.WriteLine($"{warrior1.Name} attacks");
                float attack1 = warrior1.Attack();
                float block2 = warrior2.Block();

                float dealDamage = attack1 - block2;
                if(dealDamage > 0)
                {
                    warrior2.Health -= attack1 - block2;   
                }
                else attack1 = 0;
                
                Console.WriteLine($" {warrior2.Name} HP: {warrior2.Health}, {warrior1.Name} Attack: {attack1}, {warrior2.Name} Blocks: {block2}");

                Console.WriteLine($"{warrior2.Name} attacks");
                float attack2 = warrior2.Attack();
                float block1 = warrior1.Block();
                float dealDamage2 = attack2 - block1;
                if(dealDamage2 > 0)
                {
                    warrior1.Health -= attack2 - block1;
                }
                else attack2 = 0;
                Console.WriteLine($" {warrior1.Name} HP: {warrior1.Health}, {warrior2.Name} Attack: {attack2}, {warrior1.Name} Blocks: {block1}");
            }
        }
        else
        {
            Console.WriteLine("Warrior 2 Initiates the fight...");
            while(warrior1.Health > 0 && warrior2.Health > 0)
            {
                Console.WriteLine($"{warrior2.Name} attacks");
                float attack2 = warrior2.Attack();
                float block1 = warrior1.Block();

                float dealDamage1 = attack2 - block1;
                if(dealDamage1 > 0)
                {
                    warrior1.Health -= attack2 - block1;
                }
                else attack2 = 0;
                

                Console.WriteLine($" {warrior1.Name} HP: {warrior1.Health},  {warrior2.Name} Attack: {attack2}, {warrior1.Name} Blocks: {block1}");

                Console.WriteLine($"{warrior1.Name} attacks");
                float attack1 = warrior1.Attack();
                float block2 = warrior2.Block();
                float dealDamage2 = attack1 - block2;
                if(dealDamage2 > 0)
                {
                    warrior2.Health -= attack1 - block2;
                }
                else attack1 = 0;
                Console.WriteLine($"  {warrior2.Name} HP: {warrior2.Health}, {warrior1.Name} Attack: {attack2}, , {warrior2.Name} Blocks: {block2}");

            }
        }

        Console.WriteLine("\n \t\t Finished");

    }
}