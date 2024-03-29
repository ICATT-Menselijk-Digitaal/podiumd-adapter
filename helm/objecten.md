# These are the steps we needed to perform to get a working objects and objecttypes registry. Your mileage may vary


```powershell
$OBJECTEN_URL="objectenpodiumd.dev.kiss-demo.nl"
$OBJECTTYPEN_URL="objecttypenpodiumd.dev.kiss-demo.nl"
$POSTGRES_PW_OBJECTS=
$OBJECTEN_DATABASE=objects
$OBJECTTYPEN_DATABASE=objecttypen

helm install db oci://registry-1.docker.io/bitnamicharts/postgresql --set auth.postgresPassword=$POSTGRES_PW_OBJECTS

kubectl run postgresql-client --rm --tty -i --restart='Never' --image docker.io/bitnami/postgresql:14.5.0-debian-11-r35 --env="PGPASSWORD=$POSTGRES_PW_OBJECTS" `
--command -- psql --host db-postgresql -U postgres -p 5432 -c `
"CREATE DATABASE $OBJECTEN_DATABASE"

kubectl run postgresql-client --rm --tty -i --restart='Never' --image docker.io/bitnami/postgresql:14.5.0-debian-11-r35 --env="PGPASSWORD=$POSTGRES_PW_OBJECTS" `
--command -- psql --host db-postgresql -U postgres -p 5432 -c `
"CREATE DATABASE $OBJECTTYPEN_DATABASE"

helm repo add my-repo https://maykinmedia.github.io/charts/

helm upgrade --install `
--set ingress.className=nginx `
--set ingress.hosts[0].host=$OBJECTEN_URL `
--set ingress.hosts[0].paths[0].path=/ `
--set ingress.hosts[0].paths[0].pathType=ImplementationSpecific `
--set ingress.tls[0].hosts[0]=$OBJECTEN_URL `
--set ingress.tls[0].secretName=wildcard-kiss-tls `
--set ingress.enabled=true `
--set settings.secretKey='$GENERATED_SECRET' `
--set settings.database.host=db-postgresql `
--set settings.database.name=$OBJECTEN_DATABASE `
--set settings.database.username=postgres `
--set settings.allowedHosts=$OBJECTEN_URL `
--set settings.database.password=$POSTGRES_PW_OBJECTS `
--set extraEnvVars[0]=NOTIFICATIONS_DISABLED=true `
objecten my-repo/objecten

helm upgrade --install `
--set ingress.className=nginx `
--set ingress.hosts[0].host=$OBJECTTYPEN_URL `
--set ingress.hosts[0].paths[0].path=/ `
--set ingress.hosts[0].paths[0].pathType=ImplementationSpecific `
--set ingress.tls[0].hosts[0]=$OBJECTTYPEN_URL `
--set ingress.tls[0].secretName=wildcard-kiss-tls `
--set ingress.enabled=true `
--set settings.secretKey='$GENERATED_SECRET' `
--set settings.database.host=db-postgresql `
--set settings.database.name=$OBJECTTYPEN_DATABASE `
--set settings.database.username=postgres `
--set settings.allowedHosts=$OBJECTTYPEN_URL `
--set settings.database.password=$POSTGRES_PW_OBJECTS `
--set extraEnvVars[0]=NOTIFICATIONS_DISABLED=true `
objecttypen my-repo/objecttypen


kubectl exec -it objecttypen-59854884b-j5ktf -- python src/manage.py createinitialsuperuser
kubectl exec -it objecttypen-59854884b-j5ktf -- python src/manage.py createsuperuser
```