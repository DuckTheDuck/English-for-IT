# Use a imagem oficial do SDK .NET 8 para build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copia os arquivos do projeto e restaura dependências
COPY *.sln .
COPY PCsite/*.csproj ./PCsite/
RUN dotnet restore

# Copia todo o código e faz o build
COPY PCsite/. ./PCsite/
WORKDIR /app/PCsite
RUN dotnet publish -c Release -o out

# Build da imagem final para rodar o app (runtime)
FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY --from=build /app/PCsite/out ./

# Expõe a porta padrão do ASP.NET Core
EXPOSE 8080

# Comando para iniciar a aplicação
ENTRYPOINT ["dotnet", "PCsite.dll"]
