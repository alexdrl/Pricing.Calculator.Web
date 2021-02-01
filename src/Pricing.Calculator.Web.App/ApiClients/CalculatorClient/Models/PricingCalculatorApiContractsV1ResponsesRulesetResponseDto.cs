// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Ruleset response DTO.
    /// </summary>
    public partial class PricingCalculatorApiContractsV1ResponsesRulesetResponseDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PricingCalculatorApiContractsV1ResponsesRulesetResponseDto class.
        /// </summary>
        public PricingCalculatorApiContractsV1ResponsesRulesetResponseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PricingCalculatorApiContractsV1ResponsesRulesetResponseDto class.
        /// </summary>
        /// <param name="id">Gets the identifier.</param>
        /// <param name="version">Gets the version.</param>
        /// <param name="deminimisBasePrices">Gets the deminimis base
        /// charges.</param>
        /// <param name="chargeConfigurations">Gets the charge
        /// configurations.</param>
        public PricingCalculatorApiContractsV1ResponsesRulesetResponseDto(string id = default(string), System.Guid? version = default(System.Guid?), IList<string> deminimisBasePrices = default(IList<string>), IList<PricingCalculatorApiContractsV1ResponsesChargeConfigurationResponseDto> chargeConfigurations = default(IList<PricingCalculatorApiContractsV1ResponsesChargeConfigurationResponseDto>))
        {
            Id = id;
            Version = version;
            DeminimisBasePrices = deminimisBasePrices;
            ChargeConfigurations = chargeConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public System.Guid? Version { get; private set; }

        /// <summary>
        /// Gets the deminimis base charges.
        /// </summary>
        [JsonProperty(PropertyName = "deminimisBasePrices")]
        public IList<string> DeminimisBasePrices { get; private set; }

        /// <summary>
        /// Gets the charge configurations.
        /// </summary>
        [JsonProperty(PropertyName = "chargeConfigurations")]
        public IList<PricingCalculatorApiContractsV1ResponsesChargeConfigurationResponseDto> ChargeConfigurations { get; private set; }

    }
}
