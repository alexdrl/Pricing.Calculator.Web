using Pricing.Calculator.Web.App.Models.Request.Preview;
using Pricing.Calculator.Web.App.Models.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Pricing.Calculator.Web.App.Services
{
    public interface IPreviewCalculationService
    {
        public Task<OperationResult> Calculate(PreviewRequest request, CancellationToken cancellationToken);
    }
}