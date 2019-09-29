FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Source/College.Api/College.Api.csproj", "Source/College.Api/"]
RUN dotnet restore "Source/College.Api/College.Api.csproj"
COPY . .
WORKDIR "/src/Source/College.Api"
RUN dotnet build "College.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "College.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "College.Api.dll"]