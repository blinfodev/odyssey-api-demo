<#
	OODAPI ValidateUserName Example using Windows Powershell
	Austin Brown
	B&L Information Systems

	Tested on PowerShell 5.1

	Helpful Links:
	Official Invoke-RestMethod Docs: https://docs.microsoft.com/en-us/powershell/module/Microsoft.PowerShell.Utility/Invoke-WebRequest?view=powershell-5.1
	Helpful Invoke-RestMethod examples: https://www.jokecamp.com/blog/invoke-restmethod-powershell-examples/
#>

# The URL to your OODAPI installation, without a trailing / character
$apiURL = "https://your-server.com/odyssey/OODAPI"

# Construct the Body the HTTP Request
$data = @{
    UserName="Your Username"
    Password="Your Password"
}
$json = $data | ConvertTo-Json

# Configure the headers of the HTTP Request
$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("X-API-KEY", "xxxx-xxxx-xxxx")

# This header prevents powershell from caching the response of repeated requests
$headers.Add("Cache-Control", "no-cache")

# Call the OODAPI's ValidateUserName procedure
$response = Invoke-RestMethod "$apiURL/System/ValidateUserName" -Headers $headers -Method POST -Body $json -ContentType "application/json"

# You can use the following command to print the response of the request to the terminal
# $response | ConvertTo-Json

# This value is "True" if the username and password is valid. Otherwise, it is "False"
If ($response.Success -eq "True") {
  "Valid username and password."
}
Else
{
  "Invalid username and password."
}