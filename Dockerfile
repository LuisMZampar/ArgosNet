FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ArgosNet.csproj", "./"]
RUN dotnet restore "./ArgosNet.csproj"

COPY . .
WORKDIR "/src"
RUN dotnet build "ArgosNet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ArgosNet.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ASPNETCORE_URLS=http://0.0.0.0:80
ENTRYPOINT ["dotnet", "ArgosNet.dll"]
