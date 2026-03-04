using ClassLibrary;
using ClassLibrary.AbstractFactory;
using ClassLibrary.Factory.Enums;
using System.Text;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethodDemonstration();
            AbstractFactoryMethodDemonstration();

        }

        private static void FactoryMethodDemonstration()
        {
            var domSub = new ManagerCall().CreateSubscription(SubscriptionType.Domestic);
            var edSub = new MobileApp().CreateSubscription(SubscriptionType.Educational);
            var preSub = new WebSite().CreateSubscription(SubscriptionType.Premium);

            var sb = new StringBuilder();

            sb.AppendLine(domSub.ToString());
            sb.AppendLine(edSub.ToString());
            sb.AppendLine(preSub.ToString());

            Console.WriteLine(sb.ToString());
        }

        private static void AbstractFactoryMethodDemonstration()
        {
            var simsangFactory = new SimsangFactory();
            var uvidiaFactory = new UvidiaFactory();
            var venoloFactory = new VenoloFactory();


            simsangFactory.CreatePhone().Call("380985446867");
            uvidiaFactory.CreateLaptop().CompileCode("C#");
            venoloFactory.CreateEbook().OpenBook("Why");
        }
    }
}
