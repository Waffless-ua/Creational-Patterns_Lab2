using ClassLibrary.Factory.Enums;

namespace ClassLibrary
{
    public class MobileApp : SubscriptionCreator
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

            sub.Features.Add("App discount");

            return sub;
        }
    }
}

