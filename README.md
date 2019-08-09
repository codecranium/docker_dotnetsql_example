*** Docker container Example ***


Requirements:  dotnet core v2.2
https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.401-windows-x64-installer

[Commands to run for creating the SQL Server docker container]
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=T3stPassW0rd!2019" -p 1433:1433 --name sqlserver -v -d microsoft/mssql-server-linux

[Pull down the dotnet code from this repository and run the following commands]
navigate to the folder with the project once pulled down
dotnet publish -c Release -o out
docker build -t dotnet-example .
docker run -d --rm -p 5000:5000 --link sqlserver --name dotnetsql -e SQLSERVER_HOST=sqlserver dotnet-example



Test it out by going to the following from the host server's browser: http://localhost:5000/api/products

