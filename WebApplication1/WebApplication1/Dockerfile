#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebApplication1/WebApplication1.csproj", "WebApplication1/"]
COPY ["WebApplication1.Infrastrucure/WebApplication1.Infrastrucure.csproj", "WebApplication1.Infrastrucure/"]
COPY ["WebApplication1.Domain.Core/WebApplication1.Domain.Core.csproj", "WebApplication1.Domain.Core/"]
COPY ["WebApplication1.Domain/WebApplication1.Domain.csproj", "WebApplication1.Domain/"]
COPY ["WebApplication1.Application/WebApplication1.Application.csproj", "WebApplication1.Application/"]
COPY ["WebApplication1.Domain.Services/WebApplication1.Domain.Services.csproj", "WebApplication1.Domain.Services/"]
RUN dotnet restore "WebApplication1/WebApplication1.csproj"
COPY . .
WORKDIR "/src/WebApplication1"
RUN dotnet build "WebApplication1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication1.dll"]