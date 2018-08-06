FROM microsoft/aspnetcore:2.1 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.1 AS build
WORKDIR /src
COPY Store2018.sln ./
COPY Store2018/Store2018.csproj Store2018/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/Store2018
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Store2018.dll"]
