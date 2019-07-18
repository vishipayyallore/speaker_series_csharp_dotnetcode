FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY HelloSerivce.csproj HelloSerivce/
RUN dotnet restore HelloSerivce/HelloSerivce.csproj
WORKDIR /src/HelloSerivce
COPY . .

RUN dotnet build HelloSerivce.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish HelloSerivce.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HelloService.dll"]