az containerapp env create \
  --name 'my-env' \
  --resource-group 'my-group' \
  --logs-workspace-id $LOG_CLIENT_ID \
  --logs-workspace-key $LOG_CLIENT_SECRET \
  --location "$LOCATION" \
  --query provisioningState

az containerapp create \
  --name parts-unlimited \
  --resource-group 'my-group' \
  --environment 'my-env' \
  --image partsunlimitedweb.azurecr.io/app:v1.1 \
  --target-port 80 \
  --ingress 'external' \
  --query configuration.ingress.fqdn