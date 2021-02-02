using Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models;
using Pricing.Calculator.Web.App.Models.Request.Forward;

namespace Pricing.Calculator.Web.App.Models.Request.Preview
{
    public class PreviewRequest
    {
        public Order CalculationDto { get; set; }

        public RulesetDto RulesetDto { get; set; }
    }
}