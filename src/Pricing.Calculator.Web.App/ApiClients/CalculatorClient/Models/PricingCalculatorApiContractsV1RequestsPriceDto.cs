// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Price DTO.
    /// </summary>
    public partial class PriceDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PriceDto class.
        /// </summary>
        public PriceDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PriceDto class.
        /// </summary>
        /// <param name="value">Monetary value</param>
        /// <param name="currencyIso">An ISO 4217 currency code string.</param>
        public PriceDto(double value, string currencyIso = default(string))
        {
            CurrencyIso = currencyIso;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets an ISO 4217 currency code string.
        /// </summary>
        [JsonProperty(PropertyName = "currencyIso")]
        public string CurrencyIso { get; private set; }

        /// <summary>
        /// Gets or sets monetary value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

    }
}
