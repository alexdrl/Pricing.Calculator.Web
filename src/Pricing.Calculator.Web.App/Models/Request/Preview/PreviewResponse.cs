using Pricing.Calculator.Web.App.Models.Response;

namespace Pricing.Calculator.Web.App.Models.Request.Preview
{
    public class PreviewResponse
    {
        /// <summary>
        /// Gets Identifier
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets Production Calculation
        /// </summary>
        public Calculation ProductionCalculation { get; }

        /// <summary>
        /// Gets Preview Calculation
        /// </summary>
        public Calculation PreviewCalculation { get; }
    }
}