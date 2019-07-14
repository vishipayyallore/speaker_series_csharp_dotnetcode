FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY myMicroservice.csproj myMicroservice/

RUN dotnet restore myMicroservice/myMicroservice.csproj

WORKDIR /src/myMicroservice
COPY . .

RUN dotnet build myMicroservice.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish myMicroservice.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HelloService.dll"]