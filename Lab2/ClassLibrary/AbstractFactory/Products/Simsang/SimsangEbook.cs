namespace ClassLibrary.AbstractFactory
{
    public class SimsangEbook : IEbook
    {
        public void OpenBook(string name)
        {
            Console.WriteLine($"Book {name} opened on SimsangEbook");
        }
    }
}
