FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY *.sln .
COPY SportGoods.Server.API/*.csproj ./SportGoods.Server.API/
COPY SportGoods.Server.Data/*.csproj ./SportGoods.Server.Data/
COPY SportGoods.Server.Domain/*.csproj ./SportGoods.Server.Domain/
COPY SportGoods.Server.Core/*.csproj ./SportGoods.Server.Core/
COPY SportGoods.Server.Common/*.csproj ./SportGoods.Server.Common/
COPY SportGoods.Server.Tests.Unit/*.csproj ./SportGoods.Server.Tests.Unit/


RUN dotnet restore

COPY . .
RUN dotnet publish SportGoods.Server.API/SportGoods.Server.API.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 10000

ENTRYPOINT ["dotnet", "SportGoods.Server.API.dll"]
