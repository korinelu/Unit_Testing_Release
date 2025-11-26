# Use official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set working directory
WORKDIR /app

# Copy everything
COPY . .

# Restore dependencies
RUN dotnet restore ViskarSteelDevOps.sln

# Build the solution
RUN dotnet build ViskarSteelDevOps.sln -c Release

# Run tests (produce trx results)
RUN mkdir -p /app/ViskarSteel/TestResults \
    && dotnet test ViskarSteelDevOps.sln --logger "trx" --results-directory ViskarSteel/TestResults

# Publish application
RUN dotnet publish ViskarSteelDevOps.sln -c Release -o /app/publish

# Final lightweight runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/publish .
