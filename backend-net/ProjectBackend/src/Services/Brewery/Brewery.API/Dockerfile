#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/Brewery/Brewery.API/Brewery.API.csproj", "Services/Brewery/Brewery.API/"]
COPY ["Services/Brewery/Brewery.Infrastructure/Brewery.Infrastructure.csproj", "Services/Brewery/Brewery.Infrastructure/"]
COPY ["Services/Brewery/Brewery.AppLogic/Brewery.AppLogic.csproj", "Services/Brewery/Brewery.AppLogic/"]
COPY ["Services/Brewery/Brewery.Domain/Brewery.Domain.csproj", "Services/Brewery/Brewery.Domain/"]
RUN dotnet restore "Services/Brewery/Brewery.API/Brewery.API.csproj"
COPY . .
WORKDIR "/src/Services/Brewery/Brewery.API"
RUN dotnet build "Brewery.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Brewery.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Brewery.API.dll"]