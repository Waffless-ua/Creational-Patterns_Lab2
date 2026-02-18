using ClassLibrary.Factory.Enums;

namespace ClassLibrary
{
    public class ManagerCall : SubscriptionCreator
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

            return sub;
        }
    }
}