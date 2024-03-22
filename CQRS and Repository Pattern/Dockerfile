#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CQRS and Repository Pattern/CQRS and Repository Pattern.csproj", "CQRS and Repository Pattern/"]
RUN dotnet restore "CQRS and Repository Pattern/CQRS and Repository Pattern.csproj"
COPY . .
WORKDIR "/src/CQRS and Repository Pattern"
RUN dotnet build "CQRS and Repository Pattern.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CQRS and Repository Pattern.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CQRS and Repository Pattern.dll"]