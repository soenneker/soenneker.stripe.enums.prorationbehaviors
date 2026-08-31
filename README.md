[![](https://img.shields.io/nuget/v/soenneker.stripe.enums.prorationbehaviors.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.prorationbehaviors/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.prorationbehaviors/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.prorationbehaviors/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.enums.prorationbehaviors.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.prorationbehaviors/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.prorationbehaviors/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.prorationbehaviors/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Enums.ProrationBehaviors

Provides strongly typed values for controlling how Stripe handles prorations when a subscription or subscription item changes.

## Installation

```bash
dotnet add package Soenneker.Stripe.Enums.ProrationBehaviors
```

## Usage

```csharp
using Soenneker.Stripe.Enums.ProrationBehaviors;

StripeProrationBehavior behavior = StripeProrationBehavior.CreateProrations;
string stripeValue = behavior.Value; // "create_prorations"
```

`AlwaysInvoice` creates prorations and immediately invoices them, `CreateProrations` creates proration items without necessarily invoicing immediately, and `None` disables proration for the change. Choose the value as part of the billing decision rather than treating it as a display-only enum.
