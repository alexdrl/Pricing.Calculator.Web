using Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models;

namespace Pricing.Calculator.Web.App.Services
{
    public interface IRuleSetService
    {
        PricingCalculatorApiContractsV1ResponsesRulesetResponseDto GetRuleSet (string id);
    }
}