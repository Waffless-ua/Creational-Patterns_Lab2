namespace ClassLibrary.AbstractFactory
{
    public class SimsangLaptop : ILaptop
    {
        public void CompileCode(string code)
        {
            Console.WriteLine($"Code {code} compiled on SimsangLaptop");
        }
    }
}
