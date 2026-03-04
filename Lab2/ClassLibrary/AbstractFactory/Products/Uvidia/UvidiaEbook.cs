
namespace ClassLibrary.AbstractFactory
{
    public class UvidiaEbook : IEbook
    {
        public void OpenBook(string name)
        {
            Console.WriteLine($"Book {name} opened on UvidiaEbook ebook");
        }
    }
}
