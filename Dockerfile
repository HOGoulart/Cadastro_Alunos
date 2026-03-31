# 🔨 Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# copia tudo
COPY . ./

# publica o projeto
RUN dotnet publish -c Release -o out

# 🚀 Etapa de execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# copia do build
COPY --from=build /app/out .

# porta usada pelo Render
EXPOSE 8080

# inicia a aplicação
ENTRYPOINT ["dotnet", "Alunos.dll"]