FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["src/API/ERPLoja.csproj", "src/API/"]
RUN dotnet restore "src/API/ERPLoja.csproj"

COPY . .
WORKDIR "/src/src/API"
RUN dotnet publish "ERPLoja.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "ERPLoja.dll"]