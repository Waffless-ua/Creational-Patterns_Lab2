using ClassLibrary.Factory.Enums;
using System.Numerics;

namespace ClassLibrary
{
    public class WebSite : SubscriptionCreator
    {
        public override Subscription CreateSubscription(SubscriptionType type)
        {
            Subscription sub = type switch
            {
                SubscriptionType.Domestic => new DomesticSubscription(),
                SubscriptionType.Educational => new EducationalSubscription(),
                SubscriptionType.Premium => new PremiumSubscription(),
                _ => throw new ArgumentOutOfRangeException()
            };

            sub.Features.Add("Online discount");

            return sub;
        }
    }
}
