namespace ClassLibrary.AbstractFactory
{
    public class VenoloLaptop : ILaptop
    {
        public void CompileCode(string code)
        {
            Console.WriteLine($"Code {code} compiled on VenoloLaptop");
        }
    }
}
