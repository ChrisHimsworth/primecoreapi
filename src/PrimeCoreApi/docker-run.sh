dotnet restore
dotnet build
dotnet publish -c Release -o out
docker run -ti --rm -p 5000:5000 primecoreapi
