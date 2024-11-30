namespace Playground.WarriorsFight;

public class MagicWarrior : Warriors
{
    private readonly int teleportChance = 0;
    private readonly Random rand = new Random();
    private readonly ITeleport teleport;
    public MagicWarrior(
        ITeleport _teleport,
        string name = "Warrior",
        int health = 0,
        int attackMax = 0,
        int blockMax = 0,
        int teleportChance = 0
        ) 
    : base(name, health, attackMax, blockMax)
    {
        this.teleportChance = teleportChance;
        this.teleport = _teleport;
    }
    public override float Block()
    {
        int randomDodge = rand.Next(1,100);
        if(randomDodge < this.teleportChance)
        {
            Console.WriteLine($"{Name} {teleport.Teleport()}");
            return 10000;
        }
        else
        return base.Block();
    }
}