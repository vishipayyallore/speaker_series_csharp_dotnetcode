FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["College.ServicesV1/College.ServicesV1.csproj", "College.ServicesV1/"]
RUN dotnet restore "College.ServicesV1/College.ServicesV1.csproj"
COPY . .
WORKDIR "/src/College.ServicesV1"
RUN dotnet build "College.ServicesV1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "College.ServicesV1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "College.ServicesV1.dll"]