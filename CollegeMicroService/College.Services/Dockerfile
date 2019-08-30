FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["College.Services/College.Services.csproj", "College.Services/"]
RUN dotnet restore "College.Services/College.Services.csproj"
COPY . .
WORKDIR "/src/College.Services"
RUN dotnet build "College.Services.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "College.Services.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "College.Services.dll"]