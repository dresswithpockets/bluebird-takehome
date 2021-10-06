FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
ARG ENV
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000
ENV ASPNETCORE_ENVIRONMENT=${ENV}

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" bluebird && chown -R bluebird /app
USER bluebird

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./Bluebird.Background/Bluebird.Background.csproj"

RUN dotnet build "./Bluebird.Background/Bluebird.Background.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Bluebird.Background/Bluebird.Background.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bluebird.Background.dll"]
