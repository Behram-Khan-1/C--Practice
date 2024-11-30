namespace Playground.WarriorsFight;

public class Warriors
{
    public string Name {get;protected set;}
    protected float Health {get;set;}
    protected float AttackMax {get;set;}
    protected float BlockMax {get;set;}
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

    public float GetHealth() => this.Health;

    public int ReduceHealth(float damage)
    {
        return (int) (this.Health -= damage);
    }
        
    public virtual float Attack()
    {
       return rand.Next(1, (int) AttackMax);
    }
    
    public virtual float Block()
    {
       return rand.Next(1, (int) BlockMax);
    }
}