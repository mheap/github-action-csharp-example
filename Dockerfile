FROM mcr.microsoft.com/dotnet/core/sdk:3.1
COPY . /app
ENTRYPOINT ["dotnet", "run", "--project", "/app"] 