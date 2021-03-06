#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM microsoft/aspnetcore:2.0-stretch AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-stretch AS build
WORKDIR /src
COPY ["LQExtension.Api/LQExtension.Api.csproj", "LQExtension.Api/"]
COPY ["LQExtension.Common/LQExtension.Common.csproj", "LQExtension.Common/"]
COPY ["LQExtension.BLL/LQExtension.BLL.csproj", "LQExtension.BLL/"]
COPY ["LQExtension.Model/LQExtension.Model.csproj", "LQExtension.Model/"]
COPY ["LQExtension.DAL/LQExtension.DAL.csproj", "LQExtension.DAL/"]
COPY ["LQExtension.DBUtility/LQExtension.DBUtility.csproj", "LQExtension.DBUtility/"]
RUN dotnet restore "LQExtension.Api/LQExtension.Api.csproj"
COPY . .
WORKDIR "/src/LQExtension.Api"
RUN dotnet build "LQExtension.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LQExtension.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LQExtension.Api.dll"]
