# 🚀 HorizonETL

Mini ETL desarrollado en .NET que simula la integración de datos desde sistemas legacy hacia APIs modernas.

## 🧠 Contexto

En muchos sistemas heredados (como POS desarrollados en Progress 4GL), los datos suelen exportarse en archivos planos (CSV).

Este proyecto demuestra cómo implementar un flujo ETL simple para llevar esos datos hacia arquitecturas modernas basadas en APIs.

## ⚙️ Flujo ETL

- **Extract** → Lectura de archivos CSV
- **Transform** → Limpieza, normalización y cálculo de datos
- **Load** → Envío a API REST

## 🧱 Stack

- .NET 8
- CsvHelper
- HttpClient

## ▶️ Ejecución

```bash
dotnet run

Contribuir

Siéntete libre de clonar este repositorio y adaptarlo a tus necesidades.
Si encuentras alguna mejora o bug, ¡envía un Pull Request!!!

Licencia
Este proyecto está bajo la licencia [MIT].

HorizonDevs - horizondevs.net