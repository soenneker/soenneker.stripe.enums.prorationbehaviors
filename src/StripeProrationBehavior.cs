using Intellenum;

namespace Soenneker.Stripe.Enums.ProrationBehaviors;

/// <summary>
/// Stripe Proration behavior enum
/// </summary>
/// <remarks>https://docs.stripe.com/billing/subscriptions/prorations</remarks>
[Intellenum<string>]
public partial class StripeProrationBehavior
{
    /// <summary>
    /// Always prorate the subscription
    /// </summary>
    public static readonly StripeProrationBehavior AlwaysInvoice = new("always_invoice");

    /// <summary>
    /// Never prorate the subscription
    /// </summary>
    public static readonly StripeProrationBehavior None = new("none");

    /// <summary>
    /// Prorate the subscription only if the change is a downgrade
    /// </summary>
    public static readonly StripeProrationBehavior CreateProrations = new("create_prorations");
}
