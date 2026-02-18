using ClassLibrary.Factory.Enums;

namespace ClassLibrary
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            Type = SubscriptionType.Domestic;
            MonthlyFee = 10;
            MinPeriodMonths = 1;

            Channels.AddRange(new[] { "News", "Local TV", "Movies" });
            Features.Add("HD");
        }
    }
}
