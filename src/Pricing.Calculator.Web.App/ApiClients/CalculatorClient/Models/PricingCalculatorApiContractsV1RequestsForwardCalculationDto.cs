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
    /// Forward Calculation DTO implementation.
    /// </summary>
    public partial class PricingCalculatorApiContractsV1RequestsForwardCalculationDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PricingCalculatorApiContractsV1RequestsForwardCalculationDto class.
        /// </summary>
        public PricingCalculatorApiContractsV1RequestsForwardCalculationDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PricingCalculatorApiContractsV1RequestsForwardCalculationDto class.
        /// </summary>
        /// <param name="items">Gets the items DTO.</param>
        /// <param name="orderId">(Required) Order Id, Guid as string.</param>
        /// <param name="currencyIso">(Required) The currency ISO.</param>
        /// <param name="sourceCountryIso">(Optional) The source country
        /// ISO.</param>
        /// <param name="declarationCountryIso">(Required) The declaration
        /// country ISO.</param>
        /// <param name="brandCode">(Optional) The three letter brand
        /// code.</param>
        public PricingCalculatorApiContractsV1RequestsForwardCalculationDto(IList<PricingCalculatorApiContractsV1RequestsItemDto> items, string orderId = default(string), string currencyIso = default(string), string sourceCountryIso = default(string), string declarationCountryIso = default(string), string brandCode = default(string))
        {
            OrderId = orderId;
            CurrencyIso = currencyIso;
            SourceCountryIso = sourceCountryIso;
            DeclarationCountryIso = declarationCountryIso;
            BrandCode = brandCode;
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets (Required) Order Id, Guid as string.
        /// </summary>
        [JsonProperty(PropertyName = "orderId")]
        public string OrderId { get; private set; }

        /// <summary>
        /// Gets (Required) The currency ISO.
        /// </summary>
        [JsonProperty(PropertyName = "currencyIso")]
        public string CurrencyIso { get; private set; }

        /// <summary>
        /// Gets (Optional) The source country ISO.
        /// </summary>
        [JsonProperty(PropertyName = "sourceCountryIso")]
        public string SourceCountryIso { get; private set; }

        /// <summary>
        /// Gets (Required) The declaration country ISO.
        /// </summary>
        [JsonProperty(PropertyName = "declarationCountryIso")]
        public string DeclarationCountryIso { get; private set; }

        /// <summary>
        /// Gets (Optional) The three letter brand code.
        /// </summary>
        [JsonProperty(PropertyName = "brandCode")]
        public string BrandCode { get; private set; }

        /// <summary>
        /// Gets the items DTO.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<PricingCalculatorApiContractsV1RequestsItemDto> Items { get; set; }

    }
}
