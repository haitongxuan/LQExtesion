FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY LQExtension.Api/LQExtension.Api.csproj LQExtension.Api/
RUN ls -al 
RUN dotnet restore LQExtension.Api/LQExtension.Api.csproj
COPY . .
RUN ls -al
WORKDIR /src/LQExtension.Api
RUN dotnet build LQExtension.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish LQExtension.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LQExtension.Api.dll"]