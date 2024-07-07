FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet build --no-restore -c $BUILD_CONFIGURATION
RUN dotnet test --no-build -c $BUILD_CONFIGURATION

FROM base AS final
WORKDIR /app
CMD ["dotnet", "run", "--project", "StringBenchmarker.csproj", "-c", "Release"]