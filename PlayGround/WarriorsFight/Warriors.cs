namespace Playground.WarriorsFight;

public class Warriors
{
    public string Name {get;set;}
    public float Health {get;set;}
    public float AttackMax {get;set;}
    public float BlockMax {get;set;}
    Random rand = new Random();
    public Warriors(string name = "Warrior",
        int health = 0,
        int attackMax = 0,
        int blockMax = 0)
    {
        this.Name = name;
        this.Health = health;
        this.AttackMax = attackMax;
        this.BlockMax = blockMax;
    }

    public float Attack()
    {
       return rand.Next(1, (int) AttackMax);
    }
    
    public virtual float Block()
    {
       return rand.Next(1, (int) BlockMax);
    }
}