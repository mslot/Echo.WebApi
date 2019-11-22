FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Echo.WebApi/Echo.WebApi.csproj", "Echo.WebApi/"]
RUN dotnet restore "Echo.WebApi/Echo.WebApi.csproj"
COPY . .
WORKDIR "/src/Echo.WebApi"
RUN dotnet build "Echo.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Echo.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Echo.WebApi.dll"]