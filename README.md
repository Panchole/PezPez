# PezPez Operations Console

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=.net&logoColor=white)
![Blazor](https://img.shields.io/badge/Blazor-Frontend-5C2D91?logo=blazor&logoColor=white)
![FastAPI](https://img.shields.io/badge/FastAPI-Backend-009688?logo=fastapi&logoColor=white)
![MudBlazor](https://img.shields.io/badge/MudBlazor-UI%20Library-6E57FF)
![Python](https://img.shields.io/badge/Python-3.11%2B-3776AB?logo=python&logoColor=white)

PezPez Operations Console es una aplicación administrativa moderna construida con **Blazor en .NET 8** para el frontend y **FastAPI en Python** para el backend.  
La interfaz está pensada como un dashboard profesional, minimalista y fresco para administrar productos, revisar salud del sistema y visualizar actividad operativa.

---

## Tabla de contenido

- [Características](#características)
- [Stack tecnológico](#stack-tecnológico)
- [Arquitectura](#arquitectura)
- [Estructura del proyecto](#estructura-del-proyecto)
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
- Topbar minimalista.
- Navegación clara por módulos.
- Diseño responsive y consistente.

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

- .NET 8
- Blazor Web App
- MudBlazor
- CSS personalizado

### Backend

- Python 3.11+
- FastAPI
- Pydantic
- Uvicorn

### Infraestructura

- Docker / Docker Compose
- Comunicación HTTP entre frontend y backend
- Preparado para autenticación JWT/OIDC

---

## Arquitectura

El proyecto sigue una arquitectura separada por responsabilidades:

- **Frontend:** Blazor se encarga de la experiencia visual y navegación.
- **Backend:** FastAPI expone la lógica de negocio y los endpoints REST.
- **Contratos:** DTOs y modelos claros para integrar ambos lados.
- **Infraestructura:** Despliegue independiente y escalable.

### Flujo general

1. El usuario entra a la interfaz Blazor.
2. Blazor consume la API FastAPI por HTTP.
3. FastAPI valida, procesa y responde.
4. La UI presenta la información con componentes ricos y visuales.

---

## Estructura del proyecto

```bash
PezPez/
├── PezPez.Web/                # Frontend Blazor
├── PezPez.Api/                # Backend FastAPI
├── PezPez.Shared/             # Contratos compartidos opcionales
├── docker-compose.yml
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

### Backend FastAPI

```bash
PezPez.Api/
├── app/
│   ├── main.py
│   ├── api/
│   ├── core/
│   ├── models/
│   ├── schemas/
│   ├── services/
│   └── repositories/
├── requirements.txt
└── Dockerfile
```

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

- .NET 8 SDK
- Python 3.11 o superior
- Visual Studio 2022 o VS Code
- Docker opcional, pero recomendado

---

## Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/pezpez.git
cd pezpez
```

### 2. Restaurar dependencias del frontend

```bash
cd PezPez.Web
dotnet restore
```

### 3. Instalar dependencias del backend

```bash
cd ../PezPez.Api
pip install -r requirements.txt
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
uvicorn app.main:app --reload
```

### Con Docker Compose

```bash
docker compose up --build
```

---

## Variables de entorno

### Frontend

```env
API_BASE_URL=https://localhost:8000
```

### Backend

```env
APP_NAME=PezPez API
APP_ENV=development
DATABASE_URL=postgresql://user:password@localhost:5432/pezpez
```

---

## Convenciones

### Frontend

- Componentes en PascalCase.
- Archivos `.razor` con nombres descriptivos.
- CSS organizado por secciones.
- Reutilización de componentes MudBlazor.

### Backend

- API REST con rutas versionadas.
- DTOs claros en `schemas`.
- Lógica de negocio separada de acceso a datos.
- Validación explícita con Pydantic.

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
- El proyecto está pensado para evolucionar de forma limpia hacia datos reales.

---

## Licencia

Este proyecto se distribuye bajo la licencia que defina el equipo o la organización propietaria.

---

## Próximos pasos

- Conectar datos reales.
- Agregar métricas vivas.
- Implementar autenticación.
- Documentar endpoints del backend.
- Mejorar componentes de dashboard.

---

Si quieres, el siguiente paso puede ser convertir este README en una **versión más corporativa, más técnica o más orientada a open source**.
