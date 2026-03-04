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
            SubscriptionCreator creator = new ManagerCall();
            var domSub = creator.CreateSubscription(SubscriptionType.Domestic);

            creator = new MobileApp();
            var edSub = creator.CreateSubscription(SubscriptionType.Educational);

            creator = new WebSite();
            var preSub = creator.CreateSubscription(SubscriptionType.Premium);


            var sb = new StringBuilder();

            sb.AppendLine(domSub.ToString());
            sb.AppendLine(edSub.ToString());
            sb.AppendLine(preSub.ToString());

            Console.WriteLine(sb.ToString());
        }

        private static void AbstractFactoryMethodDemonstration()
        {
            IDeviceFactory deviceFactory = new SimsangFactory();
            deviceFactory.CreatePhone().Call("380985446867");

            deviceFactory = new UvidiaFactory();
            deviceFactory.CreateLaptop().CompileCode("C#");

            deviceFactory = new VenoloFactory();
            deviceFactory.CreateEbook().OpenBook("Why");
        }
    }
}
