using Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models;

namespace Pricing.Calculator.Web.App.Services
{
    public interface IRuleSetService
    {
        RulesetResponseDto GetRuleSet (string id);
    }
}