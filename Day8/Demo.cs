using System;
interface I
{
    void show();
}
class C1 : I
{
    public void show()
    {
        Console.WriteLine("Hello show from C1");
    }
}
class C2 : C1
{
    public void show2()
    {
        Console.WriteLine("Hello show2 from C2");
    }
}
class C3
{
    private string showMessage;
    public string ShowMessage
    {
        get { return showMessage; }
        set { showMessage = value; }
    }
    public void show()
    {
        Console.WriteLine(ShowMessage);
    }
}
class C4
{
    private string show2Message;
    public C4(string message)
    {
        show2Message = message;
    }
    public void show2()
    {
        Console.WriteLine(show2Message);
    }
}
class Test
{
    static void Main(string[] args)
    {
        C2 c2 = new C2();
        c2.show();
        c2.show2();
        C3 c3 = new C3();
        c3.ShowMessage = "Hello show from C3";
        c3.show();
        C4 c4 = new C4("Hello show2 from C4");
        c4.show2();
    }
}
