[CmdletBinding()]
param ()

[System.Net.ServicePointManager]::SecurityProtocol = [System.Net.SecurityProtocolType]::Tls12

$ErrorActionPreference = "Stop"

function Generate-Client 
{
	param ([string] $clientFolder)

	$endpoint = "https://localhost:44316/swagger/v1/swagger.json"
	$namespace = 'Pricing.Calculator.Web.App.ApiClients.CalculatorClient'
	$hashFile = $clientFolder + '\hCode.txt'
	$clientName = 'CalculatorApiClient'

    # Work around for autorest not supporting HTTPS
    #iwr "$endpoint" -outfile "Client.json"
    $swaggerHashCode = (iwr "$endpoint").Content.GetHashCode()
    Write-Verbose "swaggerHashCode:$swaggerHashCode"

    autorest --input-file="Client.json" --sync-methods=all --add-credentials=true --override-client-name=$clientName --clear-output-folder --namespace=$namespace --csharp --output-folder=$clientFolder --client-side-validation=$false
    # autorest --input-file="Client.json" --csharp --output-folder=$clientFolder 
}

Generate-Client '..\src\Pricing.Calculator.Web.App\ApiClients\CalculatorClient'


pause

exit 0

