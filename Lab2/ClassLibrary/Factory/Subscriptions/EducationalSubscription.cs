using ClassLibrary.Factory.Enums;

namespace ClassLibrary
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            Type = SubscriptionType.Educational;
            MonthlyFee = 5;
            MinPeriodMonths = 6;

            Channels.AddRange(new[] { "Discovery", "National Geographic" });
            Features.Add("Offline access");
        }
    }
}
