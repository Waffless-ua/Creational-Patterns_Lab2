using ClassLibrary.Factory.Enums;

namespace ClassLibrary
{
    public abstract class SubscriptionCreator
    {
        public abstract Subscription CreateSubscription(SubscriptionType type);
    }
}
