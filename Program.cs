public class Program {
    public static void Main() {
        Program p = new Program();

        p.PrivateFunction();
        p.ProtectedFunction();
        p.InternalFunctin();
        p.InternalProtectedFunction();
        p.PublicFunction();
    }

    private void PrivateFunction() {
        Console.WriteLine($"Private Function Called");
    }

    protected void ProtectedFunction() {
        Console.WriteLine("Protected Function Called");
    }

    internal void InternalFunctin() {
        Console.WriteLine("Internal Function Called");
    }

    internal protected void InternalProtectedFunction() {
        Console.WriteLine("Internal Protected Called");
    }

    public void PublicFunction() {
        Console.WriteLine("Public Function");
    }
}