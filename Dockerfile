FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app
COPY . .

# Restore dependencies
RUN dotnet restore
