namespace ClassLibrary.AbstractFactory
{
    public class VenoloPhone : IPhone
    {
         public void Call(string phoneNumber)
        {
            Console.WriteLine($"Call made with VenoloPhone on {phoneNumber}");
        }
    }
}
