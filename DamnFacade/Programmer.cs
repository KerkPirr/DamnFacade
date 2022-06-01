namespace DamnFacade;

public class Programmer
{
    public void CreateApplication(IDEFacade facade)
    {
        facade.Start();
        facade.Stop();
    }
}