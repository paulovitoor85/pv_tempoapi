# pv_tempoapi

🌦 Weather API
Uma API simples criada com .NET 8 e Docker, que retorna a previsão do tempo para os dias da semana em Celsius, Fahrenheit e Kelvin.

📌 Funcionalidades

Retorna a temperatura para cada dia da semana.
Suporta execução em Docker.
Pode ser implantada no Azure Web App.
Documentação interativa via Swagger.

🚀 Como executar localmente

1️⃣ Clonar o repositório
git clone <URL_DO_REPOSITORIO>
cd WeatherAPI

2️⃣ Rodar sem Docker
dotnet run

3️⃣ Rodar com Docker
docker build -t weather-api .
docker run -p 8080:80 weather-api

Acesse em: http://localhost:8080/api/weather

🛠 Tecnologias utilizadas
.NET 8
ASP.NET Core Web API
Docker
Swagger

📤 Implantação no Azure
1️⃣ Criar um Azure Container Registry (ACR)

az acr create --resource-group <RESOURCE_GROUP> --name <ACR_NAME> --sku Basic
az acr login --name <ACR_NAME>

2️⃣ Criar e enviar a imagem Docker para o ACR

docker tag weather-api <ACR_NAME>.azurecr.io/weather-api:v1
docker push <ACR_NAME>.azurecr.io/weather-api:v1

3️⃣ Criar um Azure Web App e configurar o container

Vá até o Azure Portal.
Crie um Web App e selecione Docker Container.
Configure a origem do container para Azure Container Registry (ACR).
Selecione a imagem weather-api:v1.

📄 Endpoints
🔹 Obter previsão do tempo

GET /api/weather

📌 Exemplo de resposta:

[
  {
    "day": "Monday",
    "temperatureCelsius": 25,
    "temperatureFahrenheit": 77,
    "temperatureKelvin": 298.15
  },
  {
    "day": "Tuesday",
    "temperatureCelsius": 30,
    "temperatureFahrenheit": 86,
    "temperatureKelvin": 303.15
  }
]





