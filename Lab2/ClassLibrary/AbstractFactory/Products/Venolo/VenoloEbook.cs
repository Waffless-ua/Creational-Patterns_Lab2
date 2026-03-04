namespace ClassLibrary.AbstractFactory
{
    public class VenoloEbook : IEbook
    {
        public void OpenBook(string name)
        {
            Console.WriteLine($"Book {name} opened on VenoloEbook");
        }
    }
}
