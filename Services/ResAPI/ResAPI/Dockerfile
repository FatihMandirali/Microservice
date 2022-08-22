#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/ResAPI/ResAPI/ResAPI.csproj", "Services/ResAPI/ResAPI/"]
COPY ["Services/ResAPI/ResAPI.Infrastructure/ResAPI.Infrastructure.csproj", "Services/ResAPI/ResAPI.Infrastructure/"]
COPY ["Services/ResAPI/ResAPI.Models/ResAPI.Models.csproj", "Services/ResAPI/ResAPI.Models/"]
COPY ["Services/ResAPI/ResAPI.Services/ResAPI.Services.csproj", "Services/ResAPI/ResAPI.Services/"]
RUN dotnet restore "Services/ResAPI/ResAPI/ResAPI.csproj"
COPY . .
WORKDIR "/src/Services/ResAPI/ResAPI"
RUN dotnet build "ResAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ResAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ResAPI.dll"]