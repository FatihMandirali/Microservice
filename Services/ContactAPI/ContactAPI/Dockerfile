#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/ContactAPI/ContactAPI/ContactAPI.csproj", "Services/ContactAPI/ContactAPI/"]
COPY ["Services/ContactAPI/ContactAPI.Infrastructure/ContactAPI.Infrastructure.csproj", "Services/ContactAPI/ContactAPI.Infrastructure/"]
COPY ["Services/ContactAPI/ContactAPI.Models/ContactAPI.Models.csproj", "Services/ContactAPI/ContactAPI.Models/"]
COPY ["Services/ContactAPI/ContactAPI.Services/ContactAPI.Services.csproj", "Services/ContactAPI/ContactAPI.Services/"]
RUN dotnet restore "Services/ContactAPI/ContactAPI/ContactAPI.csproj"
COPY . .
WORKDIR "/src/Services/ContactAPI/ContactAPI"
RUN dotnet build "ContactAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContactAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContactAPI.dll"]