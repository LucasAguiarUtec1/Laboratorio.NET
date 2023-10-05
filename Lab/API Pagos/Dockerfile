#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["API Pagos/API Pagos.csproj", "API Pagos/"]
RUN dotnet restore "API Pagos/API Pagos.csproj"
COPY . .
WORKDIR "/src/API Pagos"
RUN dotnet build "API Pagos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API Pagos.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API Pagos.dll"]