using Pricing.Calculator.Web.App.ApiClients.CalculatorClient;
using Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models;
using Pricing.Calculator.Web.App.Models;

namespace Pricing.Calculator.Web.App.Services
{
    public class RuleSetService: IRuleSetService
    {
        private readonly ICalculatorApiClient _calculatorApiClient;

        public RuleSetService (ICalculatorApiClient calculatorApiClient)
        {
            _calculatorApiClient = calculatorApiClient;
        }

        public Ruleset GetRuleSet (string id)
        {
            var response  = _calculatorApiClient.GetRuleset (id);
            var ruleset = Ruleset.FromApiRuleSetResponseDto (response);
            return ruleset;
        }
    }
}
