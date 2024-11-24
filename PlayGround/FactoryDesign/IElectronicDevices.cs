namespace Playground.FactoryDesign;

public interface IElectronicDevices
{
    void On();
    void Off();
    void VolumeUp();
    void VolumeDown();

}
public interface ICommand
{
    void Execute();
    void Undo();
}