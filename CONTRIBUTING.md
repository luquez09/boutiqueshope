# CONTRIBUTING.md

## Guía de Contribución - BoutiqueShope

Esta guía define las normas y prácticas para contribuir al proyecto BoutiqueShope (POS de ventas) y la estructura de arquitectura por capas.

### Arquitectura y estructura de proyectos

- La solución raíz debe llamarse `BoutiqueShope.sln`.
- Proyectos y namespaces deben usar PascalCase y los siguientes sufijos:
  - `BoutiqueShope.UI` - Interfaz de usuario (WinForms/WPF/Console).
  - `BoutiqueShope.Application` - Servicios de aplicación, casos de uso, DTOs, interfaces de aplicación.
  - `BoutiqueShope.Domain` - Entidades del dominio, Value Objects, reglas de negocio, interfaces de repositorio.
  - `BoutiqueShope.Infrastructure` - Implementaciones concretas (EF6, repositorios, acceso a datos, migraciones).
  - `BoutiqueShope.CrossCutting` - IoC/DI, logging, configuración, utilidades compartidas.
  - `BoutiqueShope.Tests.Unit` - Pruebas unitarias.
  - `BoutiqueShope.Tests.Integration` - Pruebas de integración.

- Cada proyecto debe apuntar a `.NET Framework 4.8`.

### Convenciones de código y estilo

- Indentación: 4 espacios, no usar tabs.
- Encoding: UTF-8.
- Nombres: PascalCase para clases, métodos y propiedades; parámetros en camelCase; campos privados con prefijo `_`.
- Interfaces comienzan con `I`.

### Flujos de trabajo y ramas

- Rama principal protegida: `main`.
- Trabajar en ramas `feature/<descripción>` o `bugfix/<descripción>`.
- PRs con descripción y pasar CI.

### Testing

- Pruebas unitarias obligatorias para lógica del dominio.
- Herramientas recomendadas: `NUnit` o `MSTest`, `Moq`, `FluentAssertions`.

### Herramientas y dependencias

- ORM recomendado: `Entity Framework 6`.
- Inyección de dependencias: `Microsoft.Extensions.DependencyInjection` o `Autofac`.

---
