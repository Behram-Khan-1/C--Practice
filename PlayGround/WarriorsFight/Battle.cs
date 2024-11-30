
namespace Playground.WarriorsFight;

public class Battle
{
    static Random rand = new Random();
    

    public static void StartFight(Warriors warrior1, Warriors warrior2)
    {
       Console.WriteLine("Battle Started...");
      
       int random = rand.Next(1, 3);
        if(random == 1)
        {
            Console.WriteLine("Warrior 1 Initiates the fight...");
            while(warrior1.GetHealth() > 0 && warrior2.GetHealth() > 0)
            {
                Fight( warrior1,  warrior2);
                (warrior1,warrior2) = (warrior2,warrior1);
            }
        }
        else
        {
            Console.WriteLine("Warrior 2 Initiates the fight...");
            while(warrior1.GetHealth() > 0 && warrior2.GetHealth() > 0)
            {
                Fight( warrior2,  warrior1);
                (warrior1,warrior2) = (warrior2,warrior1);
            }
        }
        if(warrior1.GetHealth() >= 0)
        Console.WriteLine($"\n \t\t Finished {warrior1.Name} won");
        else
        Console.WriteLine($"\n \t\t Finished {warrior2.Name} won");

    }

    private static void Fight( Warriors A,  Warriors B)
    {
        Console.WriteLine($"{A.Name} attacks");
        float healthA = A.GetHealth();
        float healthB = B.GetHealth();

        float attackA = A.Attack();
        float blockB = B.Block();

        float dealDamage = attackA - blockB;
        if (dealDamage > 0)
        {
            healthB = B.ReduceHealth(dealDamage);
        }
        else attackA = 0;

        Console.WriteLine($" {B.Name} HP: {B.GetHealth()}, {A.Name} Attack: {attackA}, {B.Name} Blocks: {blockB}");
    }
}