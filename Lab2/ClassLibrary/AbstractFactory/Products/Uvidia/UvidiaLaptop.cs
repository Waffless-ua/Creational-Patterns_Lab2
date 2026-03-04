namespace ClassLibrary.AbstractFactory
{
    public class UvidiaLaptop : ILaptop
    {
        public void CompileCode(string code)
        {
            Console.WriteLine($"Code {code} compiled on UvidiaLaptop");
        }
    }
}
