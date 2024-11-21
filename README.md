# Multibanking API

Добро пожаловать в **Multibanking API**! Этот проект предназначен для того, чтобы предоставить пользователям удобный способ взаимодействовать с несколькими банковскими сервисами, включая управление кредитами, планы рассрочек и расчет ипотеки.

## Требования

Перед тем как запустить проект локально, убедитесь, что у вас установлены следующие инструменты:

- **Docker** (для контейнеризации приложения)
- **Docker Compose** (для управления многоконтейнерными приложениями)
- **.NET 8.0 SDK** (для разработки)
- **Git** (для клонирования репозитория)

## Начало работы

### Клонирование репозитория

Начните с того, чтобы клонировать репозиторий на свой локальный компьютер:

```bash
git clone https://github.com/sleeping-bakery/vtb-backend.git
cd vtb-backend
cd Multibanking.Devops
docker-compose up --build -d
```
Сваггер можно увидеть по ссылке: //localhost/swagger

Для запуска тестов использовать
```bash
dotnet test
```

Для остановки приложений:
```bash
docker-compose down
```

Ознакомиться с бизнес логикой и архитектурой можете по ссылке:
https://disk.yandex.ru/d/oIDOIJ05R8ty3w

В качестве решения было разработано монолитное .NET приложение на основе DDD