using Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models;
using Pricing.Calculator.Web.App.Models.Request;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Pricing.Calculator.Web.App.Models
{
    public class Ruleset
    {
        [Required]
        public string SourceCountry { get; set; } = string.Empty;

        [Required]
        public string DeclarationCountry { get; set; } = string.Empty;

        public string BrandCode { get; set; } = "-";

        public string PostalMethod { get; set; } = "-";

        public string RulesetId => $"{SourceCountry}{DeclarationCountry}" == "GBIE" ? "DC:IE-SC:GB" :  $"SC:{SourceCountry}-DC:{DeclarationCountry}";

        public List<ChargeConfiguration> ChargeConfigurations { get; set; } = new List<ChargeConfiguration>();

        /// <summary>
        /// FromApiRuleSetResponseDto
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Ruleset FromApiRuleSetResponseDto (RulesetResponseDto source)
        {
            var target = new Ruleset();

            target.SourceCountry = source.Id.Split ('-').First (x => x.StartsWith ("SC")).Split (':')[1];
            target.DeclarationCountry = source.Id.Split('-').First(x => x.StartsWith("DC")).Split(':')[1];
            target.ChargeConfigurations =  source.ChargeConfigurations.Select(ChargeConfiguration.MapFrom).ToList();
            return target;
        }

        /// <summary>
        /// FromApiRuleSetResponseDto
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static RulesetDto ToRuleSetRequestDto(Ruleset source, List<string> deminimisbasePrices)
        {
            var target = new RulesetDto(deminimisbasePrices,
                source.ChargeConfigurations.Select(ChargeConfiguration.MapTo).ToList(), source.SourceCountry,
                source.DeclarationCountry);

            return target;
        }
    }
}
