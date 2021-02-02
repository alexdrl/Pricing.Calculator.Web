using Pricing.Calculator.Web.App.Models;

namespace Pricing.Calculator.Web.App.Services
{
    public interface IRuleSetService
    {
        Ruleset GetRuleSet (string id);
    }
}