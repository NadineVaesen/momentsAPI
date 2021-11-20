#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["SchoolMomentAPI/SchoolMomentAPI.csproj", "SchoolMomentAPI/"]
RUN dotnet restore "SchoolMomentAPI/SchoolMomentAPI.csproj"
COPY . .
WORKDIR "/src/SchoolMomentAPI"
RUN dotnet build "SchoolMomentAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SchoolMomentAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SchoolMomentAPI.dll"]
