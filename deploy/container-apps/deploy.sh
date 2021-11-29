az containerapp env create \
  --name 'my-env' \
  --resource-group 'my-group' \
  --logs-workspace-id $LOG_CLIENT_ID \
  --logs-workspace-key $LOG_CLIENT_SECRET \
  --location "$LOCATION"

az containerapp create \
  --name parts-unlimited \
  --resource-group 'my-group' \
  --environment 'my-env' \
  --image partsunlimited.azurecr.io/web:v1.0 \
  --target-port 80 \
  --ingress 'external'