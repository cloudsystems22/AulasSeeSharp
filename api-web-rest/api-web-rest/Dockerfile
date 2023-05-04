#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["api-web-rest/api-web-rest.csproj", "api-web-rest/"]
RUN dotnet restore "api-web-rest/api-web-rest.csproj"
COPY . .
WORKDIR "/src/api-web-rest"
RUN dotnet build "api-web-rest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "api-web-rest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "api-web-rest.dll"]