using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceTransactionACHCreditTransfer : StripeEntity
    {
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
