

namespace DamnFacade;

public class IDEFacade
{
    private TextEditor textEditor;
    private Compiler compiler;
    private CLR clr;

    public IDEFacade(TextEditor te, Compiler compil, CLR clr)
    {
        this.textEditor = te;
        this.compiler = compil;
        this.clr = clr;
    }

    public void Start()
    {
        textEditor.CreateCode();
        textEditor.Save();
        compiler.Compile();
        clr.Execute();
    }

    public void Stop()
    {
        clr.Finish();
    }
}