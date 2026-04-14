# PezPez Operations Console

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=.net&logoColor=white)
![Blazor](https://img.shields.io/badge/Blazor-Frontend-5C2D91?logo=blazor&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Backend-512BD4?logo=dotnet&logoColor=white)
![MudBlazor](https://img.shields.io/badge/MudBlazor-UI%20Library-6E57FF)
![License](https://img.shields.io/badge/License-Private-lightgrey)

PezPez Operations Console es una aplicación administrativa moderna construida con **Blazor en .NET 8** para el frontend y **ASP.NET Core Web API** para el backend.  
La interfaz fue diseñada como una consola operativa limpia, fresca y profesional para administrar productos, revisar el estado del sistema y visualizar actividad relevante desde un panel centralizado.

---

## Tabla de contenido

- [Características](#características)
- [Stack tecnológico](#stack-tecnológico)
- [Arquitectura](#arquitectura)
- [Estructura del proyecto](#estructura-del-proyecto)
- [Layout y navegación](#layout-y-navegación)
- [Home dashboard](#home-dashboard)
- [Componentes utilizados](#componentes-utilizados)
- [Requisitos previos](#requisitos-previos)
- [Instalación](#instalación)
- [Ejecución local](#ejecución-local)
- [Variables de entorno](#variables-de-entorno)
- [Convenciones](#convenciones)
- [Roadmap](#roadmap)
- [Notas importantes](#notas-importantes)

---

## Características

### Layout moderno

- Sidebar fijo y limpio.
- Topbar minimalista con búsqueda y acciones rápidas.
- Navegación clara por módulos.
- Diseño responsive y consistente en desktop y mobile.

### Home tipo dashboard

La página principal fue rediseñada como un dashboard profesional con:

- Hero de bienvenida.
- CTA principal para crear producto.
- Resumen del día.
- KPIs clave.
- Gráfica de tendencia.
- Gráfica donut de distribución.
- Actividad reciente con timeline.
- Estado del sistema.
- Acciones rápidas.
- Paneles expandibles para novedades y pendientes.

### Módulo de productos

- Lista de productos.
- Tabla con acciones.
- Estados visuales con chips.
- Diseño limpio y consistente con la Home.

---

## Stack tecnológico

### Frontend

- **.NET 8**
- **Blazor Web App**
- **MudBlazor**
- CSS personalizado

### Backend

- **ASP.NET Core Web API**
- C# / .NET 8
- Validación y modelado con DTOs
- API REST

### Infraestructura

- Docker / Docker Compose opcional
- Comunicación HTTP entre frontend y backend
- Preparado para autenticación JWT/OIDC

---

## Arquitectura

El proyecto sigue una arquitectura separada por responsabilidades:

- **Frontend:** Blazor se encarga de la experiencia visual, navegación y composición de la UI.
- **Backend:** ASP.NET Core Web API expone la lógica de negocio y los endpoints REST.
- **Contratos:** DTOs y modelos compartidos para mantener integración clara.
- **Infraestructura:** despliegue independiente y escalable por capa.

### Flujo general

1. El usuario entra a la interfaz Blazor.
2. Blazor consume la API ASP.NET Core por HTTP.
3. La API valida, procesa y responde.
4. La UI presenta la información mediante componentes ricos y visuales.

---

## Estructura del proyecto

```bash
PezPez/
├── PezPez.Web/                # Frontend Blazor
├── PezPez.Api/                # Backend ASP.NET Core Web API
├── PezPez.Shared/             # DTOs/contratos compartidos opcionales
├── PezPez.sln
└── README.md
```

### Frontend Blazor

```bash
PezPez.Web/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   ├── Pages/
│   │   ├── Home.razor
│   │   ├── Products.razor
│   │   └── Health.razor
│   └── Shared/
├── wwwroot/
│   └── css/
│       └── app.css
└── Program.cs
```

### Backend ASP.NET Core Web API

```bash
PezPez.Api/
├── Controllers/
├── Models/
├── DTOs/
├── Services/
├── Data/
├── Program.cs
├── appsettings.json
└── appsettings.Development.json
```

---

## Layout y navegación

La UI actual fue ajustada para evitar el look de template genérico y lograr una apariencia más profesional.

### Sidebar

- Panel lateral fijo.
- Logo circular inicial.
- Nombre de la aplicación.
- Secciones: General y Examples.
- Estados activos claramente visibles.

### Topbar

- Título de sistema.
- Campo de búsqueda.
- Acciones rápidas.
- Avatar de usuario.

### Navegación

- Dashboard.
- Health.
- Productos.
- Counter.
- Weather.

La estructura actual busca un equilibrio entre simplicidad visual y sensación de sistema real.

---

## Home dashboard

La Home actual incluye:

### Hero

- Bienvenida personalizada.
- Resumen breve del sistema.
- Botones rápidos para navegar.

### KPIs

- Productos activos.
- Stock total.
- Salud del sistema.
- Seguimiento.

### Analítica visual

- Línea semanal con dos series.
- Donut chart de distribución.
- Insights rápidos.
- Panels de novedades.

### Actividad reciente

- Timeline de eventos.
- Productos actualizados.
- Health checks.
- Alertas operativas.
- Inicio de sesión.

### Estado del sistema

- Backend online.
- Base de datos estable.
- Interfaz óptima.
- Barras de progreso.

---

## Componentes utilizados

### Layout

- `MudAppBar`
- `MudDrawer`
- `MudGrid`
- `MudPaper`

### UI y acciones

- `MudCard`
- `MudChip`
- `MudButton`
- `MudIconButton`
- `MudTooltip`
- `MudList`

### Visualización y estado

- `MudChart`
- `MudTimeline`
- `MudProgressLinear`
- `MudExpansionPanels`
- `MudExpansionPanel`

---

## Requisitos previos

Antes de ejecutar el proyecto necesitas:

- **.NET 8 SDK**
- **Visual Studio 2022** o **VS Code**
- **ASP.NET Core runtime** incluido con el SDK
- Docker opcional, pero recomendado si vas a contenedores

---

## Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/pezpez.git
cd pezpez
```

### 2. Restaurar dependencias

```bash
dotnet restore
```

### 3. Compilar la solución

```bash
dotnet build
```

---

## Ejecución local

### Frontend

```bash
cd PezPez.Web
dotnet run
```

### Backend

```bash
cd PezPez.Api
dotnet run
```

### Ejecutar desde la solución

```bash
dotnet run --project PezPez.Api
dotnet run --project PezPez.Web
```

### Con Docker Compose

```bash
docker compose up --build
```

---

## Variables de entorno

### Frontend

Normalmente el frontend consumirá la API mediante una base URL configurada en appsettings o variables de entorno.

```env
API_BASE_URL=https://localhost:5001
```

### Backend

Las configuraciones típicas de ASP.NET Core pueden definirse así:

```env
ASPNETCORE_ENVIRONMENT=Development
ConnectionStrings__DefaultConnection=Server=localhost;Database=PezPez;Trusted_Connection=True;TrustServerCertificate=True
```

También puedes usar:

- `appsettings.json`
- `appsettings.Development.json`
- secretos de usuario en desarrollo
- variables de entorno en producción

---

## Convenciones

### Frontend

- Componentes en PascalCase.
- Archivos `.razor` con nombres descriptivos.
- CSS organizado por secciones.
- Reutilización de componentes MudBlazor.

### Backend

- API REST con rutas versionadas.
- DTOs claros en `DTOs`.
- Lógica de negocio separada de acceso a datos.
- Validación explícita y respuestas consistentes.

### UI

- Fondo neutro.
- Tarjetas elevadas con bordes suaves.
- Uso controlado del color.
- Espaciado generoso.
- Jerarquía visual clara.

---

## Roadmap

### Fase 1

- Consolidar Home.
- Terminar módulo de productos.
- Conectar health real.

### Fase 2

- Integrar autenticación.
- Agregar usuario actual.
- Reemplazar datos mock por datos reales.

### Fase 3

- Métricas en tiempo real.
- Auditoría.
- Notificaciones.
- Mejoras móviles.

### Fase 4

- Reportes.
- Exportación.
- Roles y permisos.
- Observabilidad avanzada.

---

## Notas importantes

- La Home fue diseñada como dashboard real, no como una página vacía.
- La gráfica simple fue reemplazada por una sección más dinámica.
- Se añadieron componentes nuevos para enriquecer la interfaz.
- El layout fue estabilizado para evitar desalineación entre sidebar y contenido.
- El proyecto está pensado para evolucionar de forma limpia hacia datos reales desde la API.

---

## Próximos pasos

- Conectar datos reales desde ASP.NET Core.
- Agregar métricas vivas.
- Implementar autenticación.
- Documentar endpoints del backend.
- Mejorar componentes de dashboard.
- Agregar estados vacíos, carga y error bien diseñados.

---

## Licencia

Este proyecto se distribuye bajo la licencia que defina el equipo o la organización propietaria.
