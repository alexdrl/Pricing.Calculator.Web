using Pricing.Calculator.Web.App.Models.Request;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public List<ChargeConfiguration> ChargeConfigurations { get; set; } = new List<ChargeConfiguration>();
    }
}
