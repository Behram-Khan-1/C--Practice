
namespace Playground.FactoryDesign;

public class TVRemote
{
     public static IElectronicDevices GetDevices()
     {
        return new Television();
     }
}
public class PowerButton : ICommand
{

    IElectronicDevices device;
    public PowerButton(IElectronicDevices _device)
    {
        device = _device;
    }
    public void Execute()
    {
        device.On();
    }

    public void Undo()
    {
        device.Off();
    }
}