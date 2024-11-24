namespace Playground.WarriorsFight;

public class CanTeleport : ITeleport
{
    public string Teleport()
    {
        return "Teleporting away";
    }
}

public class CantTeleport : ITeleport
{
    public string Teleport()
    {
        return "Cannot Teleport away";
    }
}