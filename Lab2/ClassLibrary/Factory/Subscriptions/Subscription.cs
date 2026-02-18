using ClassLibrary.Factory.Enums;
using System.Text;

namespace ClassLibrary
{
    public abstract class Subscription
    {
        public SubscriptionType Type { get; set; }
        public decimal MonthlyFee { get; protected set; }
        public int MinPeriodMonths { get; protected set; }
        public List<string> Channels { get; protected set; } = new();
        public List<string> Features { get; protected set; } = new();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Price: {MonthlyFee}");
            sb.AppendLine($"Min period: {MinPeriodMonths} months");
            sb.AppendLine("Channels: " + string.Join(", ", Channels));
            sb.AppendLine("Features: " + string.Join(", ", Features));

            return sb.ToString();
        }
    }
}
