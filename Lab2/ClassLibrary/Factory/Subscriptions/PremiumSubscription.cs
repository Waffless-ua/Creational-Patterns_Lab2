using ClassLibrary.Factory.Enums;

namespace ClassLibrary
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            Type = SubscriptionType.Premium;
            MonthlyFee = 20;
            MinPeriodMonths = 1;

            Channels.AddRange(new[] { "All channels", "Sports", "Kids" });
            Features.AddRange(new[] { "4K", "Multi-device", "No ads" });
        }
    }
}
