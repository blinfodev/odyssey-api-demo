########
#	OODAPI ValidateUsername Example using Windows cURL
#	Austin Brown
#	B&L Information Systems
########

# The location to your OODAPI, without a trailing slash
apiURL="https://api.blinfo.com/spectrum"

# Your OODAPI Key
apiKey="xxxx-xxxx-xxxx"

# Test a Username and Password
username="myUsername"
password="myPassword"

curl --location --request POST "$apiURL/System/ValidateUsername" \
  --header "X-API-Key: $apiKey" \
  --header "Content-Type: application/json" \
  --data "{
  \"Username\": \"$username\",
  \"Password\": \"$password\"
}"