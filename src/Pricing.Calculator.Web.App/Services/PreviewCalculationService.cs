using Microsoft.AspNetCore.Mvc;
using Pricing.Calculator.Web.App.Models.Request.Preview;
using Pricing.Calculator.Web.App.Models.Response;
using Pricing.Calculator.Web.App.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Pricing.Calculator.Web.App.Preview
{
    public class PreviewCalculationService : IPreviewCalculationService
    {
        private readonly HttpClient _httpClient;

        public PreviewCalculationService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<OperationResult> Calculate(PreviewRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/v1/rulesets/PreviewRuleset", request, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                var calculation = await response.Content.ReadFromJsonAsync<PreviewResponse>(null, cancellationToken);

                if (calculation is not null)
                    return OperationResult<PreviewResponse>.Success(calculation);

                return OperationResult.Fail(new Dictionary<string, string[]>
                {
                    { "Serialization Error", new [] { "Unable to deserialize response." } }
                });
            }

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>(null, cancellationToken);

                if (problemDetails is not null)
                    return OperationResult.Fail(problemDetails.Errors);

                return OperationResult.Fail(new Dictionary<string, string[]>
                {
                    { "Bad Request", new [] { "Unable to deserialize validation errors in response." } }
                });
            }

            return OperationResult.Fail(new Dictionary<string, string[]>
            {
                { "Unknown Failure", new [] { "An unknown failure has occurred." } }
            });
        }
    }
}
