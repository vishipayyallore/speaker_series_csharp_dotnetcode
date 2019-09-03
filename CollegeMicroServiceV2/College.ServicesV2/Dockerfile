FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["College.ServicesV2/College.ServicesV2.csproj", "College.ServicesV2/"]
RUN dotnet restore "College.ServicesV2/College.ServicesV2.csproj"
COPY . .
WORKDIR "/src/College.ServicesV2"
RUN dotnet build "College.ServicesV2.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "College.ServicesV2.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "College.ServicesV2.dll"]