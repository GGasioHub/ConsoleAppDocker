FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish "ConsoleAppDocker.csproj" -o /publish /p:UseApphost=false


FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ConsoleAppDocker.dll"]