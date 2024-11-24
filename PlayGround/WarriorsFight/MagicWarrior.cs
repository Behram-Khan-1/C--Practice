namespace Playground.WarriorsFight;

public class MagicWarrior : Warriors
{
    int teleportChance = 0;
    Random rand = new Random();
    CanTeleport canTeleport = new CanTeleport();
    public MagicWarrior(string name = "Warrior",
    int health = 0,
    int attackMax = 0,
    int blockMax = 0,
    int teleportChance = 0) 
    : base(name, health, attackMax, blockMax)
    {
        this.teleportChance = teleportChance;
    }
    public override float Block()
    {
        int randomDodge = rand.Next(1,100);
        if(randomDodge < this.teleportChance)
        {
            Console.WriteLine($"{Name} {canTeleport.Teleport()}");
            return 10000;
        }
        else
        return base.Block();
    }
}