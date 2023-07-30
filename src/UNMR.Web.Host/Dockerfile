FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/UNMR.Web.Host/UNMR.Web.Host.csproj", "src/UNMR.Web.Host/"]
COPY ["src/UNMR.Web.Core/UNMR.Web.Core.csproj", "src/UNMR.Web.Core/"]
COPY ["src/UNMR.Application/UNMR.Application.csproj", "src/UNMR.Application/"]
COPY ["src/UNMR.Core/UNMR.Core.csproj", "src/UNMR.Core/"]
COPY ["src/UNMR.EntityFrameworkCore/UNMR.EntityFrameworkCore.csproj", "src/UNMR.EntityFrameworkCore/"]
WORKDIR "/src/src/UNMR.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/UNMR.Web.Host", "src/UNMR.Web.Host"]
COPY ["src/UNMR.Web.Core", "src/UNMR.Web.Core"]
COPY ["src/UNMR.Application", "src/UNMR.Application"]
COPY ["src/UNMR.Core", "src/UNMR.Core"]
COPY ["src/UNMR.EntityFrameworkCore", "src/UNMR.EntityFrameworkCore"]
WORKDIR "/src/src/UNMR.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "UNMR.Web.Host.dll"]
