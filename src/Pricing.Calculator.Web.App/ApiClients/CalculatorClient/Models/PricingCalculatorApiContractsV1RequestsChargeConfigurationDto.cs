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
    /// Representation of a ruleset.
    /// </summary>
    public partial class ChargeConfigurationDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ChargeConfigurationDto
        /// class.
        /// </summary>
        public ChargeConfigurationDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ChargeConfigurationDto
        /// class.
        /// </summary>
        /// <param name="name">Name of the charge.</param>
        /// <param name="rate">Rate that the charge is applied on.</param>
        /// <param name="baseChargeNames">The base charges on which this charge
        /// is applied.</param>
        /// <param name="activeFrom">The date in which the charge is
        /// active.</param>
        public ChargeConfigurationDto(string chargeType, string name = default(string), DeminimisDto deminimis = default(DeminimisDto), double? rate = default(double?), IList<string> baseChargeNames = default(IList<string>), PriceDto fixedChargeAmount = default(PriceDto), System.DateTime? activeFrom = default(System.DateTime?), PriceDto minimumPayable = default(PriceDto), PriceDto maximumPayable = default(PriceDto), PriceDto minimumCollectible = default(PriceDto), PriceDto excess = default(PriceDto))
        {
            Name = name;
            Deminimis = deminimis;
            Rate = rate;
            ChargeType = chargeType;
            BaseChargeNames = baseChargeNames;
            FixedChargeAmount = fixedChargeAmount;
            ActiveFrom = activeFrom;
            MinimumPayable = minimumPayable;
            MaximumPayable = maximumPayable;
            MinimumCollectible = minimumCollectible;
            Excess = excess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the charge.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deminimis")]
        public DeminimisDto Deminimis { get; set; }

        /// <summary>
        /// Gets rate that the charge is applied on.
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "chargeType")]
        public string ChargeType { get; set; }

        /// <summary>
        /// Gets the base charges on which this charge is applied.
        /// </summary>
        [JsonProperty(PropertyName = "baseChargeNames")]
        public IList<string> BaseChargeNames { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fixedChargeAmount")]
        public PriceDto FixedChargeAmount { get; set; }

        /// <summary>
        /// Gets the date in which the charge is active.
        /// </summary>
        [JsonProperty(PropertyName = "activeFrom")]
        public System.DateTime? ActiveFrom { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumPayable")]
        public PriceDto MinimumPayable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maximumPayable")]
        public PriceDto MaximumPayable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumCollectible")]
        public PriceDto MinimumCollectible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "excess")]
        public PriceDto Excess { get; set; }

    }
}
