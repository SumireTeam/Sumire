FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Sumire/Sumire.csproj", "Sumire/"]
RUN dotnet restore "Sumire/Sumire.csproj"
COPY . .
WORKDIR "/src/Sumire"
RUN dotnet build "Sumire.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Sumire.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Sumire.dll"]