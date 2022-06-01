namespace DamnFacade;

class Program
{
    static void Main(string[] args)
    {
        TextEditor textEditor = new TextEditor();
        Compiler compiler = new Compiler();
        CLR clr = new CLR();
        IDEFacade ide = new IDEFacade(textEditor, compiler, clr);
        Programmer programmer = new Programmer();
        programmer.CreateApplication(ide);
    }
}