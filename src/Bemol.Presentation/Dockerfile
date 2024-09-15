# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Bemol.Presentation/Bemol.Presentation.csproj", "Bemol.Presentation/"]
COPY ["Bemol.Application/Bemol.Application.csproj", "Bemol.Application/"]
COPY ["Bemol.Domain/Bemol.Domain.csproj", "Bemol.Domain/"]
COPY ["Bemol.Infrastructure/Bemol.Infrastructure.csproj", "Bemol.Infrastructure/"]

RUN dotnet restore "./Bemol.Presentation/Bemol.Presentation.csproj"

COPY . .
WORKDIR "/src/Bemol.Presentation"
RUN dotnet build "./Bemol.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bemol.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bemol.Presentation.dll"]