using Pricing.Calculator.Web.App.ApiClients.CalculatorClient;
using Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models;

namespace Pricing.Calculator.Web.App.Services
{
    public class RuleSetService: IRuleSetService
    {
        private readonly ICalculatorApiClient _calculatorApiClient;

        public RuleSetService (ICalculatorApiClient calculatorApiClient)
        {
            _calculatorApiClient = calculatorApiClient;
        }

        public RulesetResponseDto GetRuleSet (string id)
        {
            var ruleSet  = _calculatorApiClient.GetRuleset (id);
            return ruleSet;
        }
    }
}
