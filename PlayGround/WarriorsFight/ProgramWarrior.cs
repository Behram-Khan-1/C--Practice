

namespace Playground.WarriorsFight;
public class ProgramWarrior
{
    static void Main()
    {
        var thor = new Warriors("Thor", 120, 30, 5);    
        // var hulk = new Warriors("Hulk", 100, 27, 3);    
        var loki = new MagicWarrior(new CanTeleport(),"Loki", 75, 27, 3,50);    
        Battle.StartFight(thor, loki);
    }
  
}

