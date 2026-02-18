using ClassLibrary;
using ClassLibrary.Factory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethodDemonstration();


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
    }
}
