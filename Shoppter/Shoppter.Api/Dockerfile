FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Shoppter.Api/Shoppter.Api.csproj", "Shoppter.Api/"]
RUN dotnet restore "Shoppter.Api/Shoppter.Api.csproj"
COPY . .
WORKDIR "/src/Shoppter.Api"
RUN dotnet build "Shoppter.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shoppter.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shoppter.Api.dll"]
