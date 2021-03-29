FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["dotnet1/dotnet1.csproj", "dotnet1/"]
RUN dotnet restore "dotnet1/dotnet1.csproj"
COPY . .
WORKDIR "/src/dotnet1"
RUN dotnet build "dotnet1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dotnet1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dotnet1.dll"]
