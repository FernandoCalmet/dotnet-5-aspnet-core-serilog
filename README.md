# 🦄 C# ASP.NET CORE 5 WEB SERILOG

[![Github][github-shield]][github-url]
[![Kofi][kofi-shield]][kofi-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Khanakat][khanakat-shield]][khanakat-url]

## TABLA DE CONTENIDO

* [Acerca del proyecto](#acerca-del-proyecto)
* [Instalación](#instalación)
* [Resumen teórico](#resumen-teórico)
* [Dependencias](#dependencias)
* [Licencia](#licencia)

## 🔥 ACERCA DEL PROYECTO

Este proyecto es una muestra de una aplicación con Serilog. Se utilizo ``ASP.NET Core 5 Web`` con C#.

## ⚙️ INSTALACIÓN

Clonar el repositorio.

```bash
gh repo clone FernandoCalmet/dotnet-5-aspnet-core-serilog
```

Ejecutar aplicación.

```bash
dotnet run
```

## 📓 RESUMEN TEÓRICO

Serilog es una biblioteca de registro de terceros que se conecta al ILogger predeterminado de nuestra aplicación con sus propias implementaciones. Permite a los desarrolladores registrar los eventos en varios destinos como consola, archivo, base de datos y más. Ahora, si ya está utilizando una base de datos en su aplicación ASP.NET Core, registrar eventos en una base de datos puede ser una buena opción. Serilog admite el registro estructurado, que permite registrar más detalles e información sobre el evento. Con el registro estructurado en su lugar, puede usar estos registros para depurar de una manera muy lógica.

## 📥 DEPENDENCIAS

- [Serilog.AspNetCore](https://www.nuget.org/packages/Serilog.AspNetCore/4.1.1-dev-00241) : Soporte de Serilog para el registro de ASP.NET Core.
- [Serilog.Enrichers.Environment](https://www.nuget.org/packages/Serilog.Enrichers.Environment/2.2.1-dev-00787) : Enriquezca los eventos de registro de Serilog con propiedades de System.Environment.
- [Serilog.Enrichers.Process](https://www.nuget.org/packages/Serilog.Enrichers.Process/) : El enriquecedor de procesos para Serilog.
- [Serilog.Enrichers.Thread](https://www.nuget.org/packages/Serilog.Enrichers.Thread/3.2.0-dev-00752) : Enriquece los eventos de Serilog con propiedades del hilo actual.
- [Serilog.Settings.Configuration](https://www.nuget.org/packages/Serilog.Settings.Configuration/) : Compatibilidad con Microsoft.Extensions.Configuration (appsettings.json) para Serilog.
- [Serilog.Sinks.MSSqlServer](https://www.nuget.org/packages/Serilog.Sinks.MSSqlServer/5.7.0-dev-00405) : Un receptor Serilog que escribe eventos en Microsoft SQL Server.

## 📄 LICENCIA

Este proyecto está bajo la Licencia (Licencia MIT) - mire el archivo [LICENSE](LICENSE) para más detalles.

## ⭐️ DAME UNA ESTRELLA

Si esta Implementación le resultó útil o la utilizó en sus Proyectos, déle una estrella. ¡Gracias! O, si te sientes realmente generoso, [¡Apoye el proyecto con una pequeña contribución!](https://ko-fi.com/fernandocalmet).

<!--- reference style links --->
[github-shield]: https://img.shields.io/badge/-@fernandocalmet-%23181717?style=flat-square&logo=github
[github-url]: https://github.com/fernandocalmet
[kofi-shield]: https://img.shields.io/badge/-@fernandocalmet-%231DA1F2?style=flat-square&logo=kofi&logoColor=ff5f5f
[kofi-url]: https://ko-fi.com/fernandocalmet
[linkedin-shield]: https://img.shields.io/badge/-fernandocalmet-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/fernandocalmet
[linkedin-url]: https://www.linkedin.com/in/fernandocalmet
[khanakat-shield]: https://img.shields.io/badge/khanakat.com-brightgreen?style=flat-square
[khanakat-url]: https://khanakat.com
