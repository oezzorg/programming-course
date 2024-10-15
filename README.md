# Curso de Programación
El objetivo principal de esta guía es ayudar a nuevos programadores para que mejoren su nivel con el fin de prepararse para un ambiente laboral.
Los conceptos tratados en esta guía son los considerados fundamentales para construir proyectos reales, así que se obviarán algunos conceptos más específicos.
A continuación se muestra el contenido del curso, desde la instalación de herramientas necesarias para continuar el curso, hasta conceptos más avanzados que irán agregándose progresivamente:

## [Instalación de herramientas 🛠️](./docs/ToolsInstallation.md)
1. [Instalación de GIT](./docs/ToolsInstallation.md#1-instalación-de-git)
2. [Backend](./docs/ToolsInstallation.md#2-backend)
    - Instalación de .NET SDK
    - Instalación de Visual Studio/Jetbrains Rider
3. [Base de Datos](./docs/ToolsInstallation.md#3-base-de-datos)
    - Instalación de PostgreSQL
    - Instalación de Jetbrains DataGrip
4. [Frontend](./docs/ToolsInstallation.md#4-frontend)
    - Instalación de NodeJS
    - Instalación de Angular CLI 

## [Módulo 1: Fundamentos de Programación](./docs/ProgrammingFundamentals.md)
### [1.1 Introducción a la Programación](./docs/ProgrammingFundamentals.md#11-introducción-a-la-programación)
- Variables, tipos de datos y operadores
- Estructuras de control (if, switch, bucles)
- Funciones y procedimientos

### [1.2 Programación Orientada a Objetos (POO)](./docs/ProgrammingFundamentals.md#12-programación-orientada-a-objetos-poo)
- Clases y objetos
- Encapsulamiento, herencia y polimorfismo
- Interfaces y clases abstractas
- Niveles de acceso

## Módulo 2: Introducción a .NET y ASP.NET Core
### 2.1 Instalación y Configuración de .NET Core
- Instalación de .NET SDK
- Introducción a Visual Studio/Visual Studio Code/Jetbrains Rider
- Estructura básica de un proyecto .NET

### 2.2 Creación de una API RESTful con ASP.NET Core
- Introducción a los controladores y acciones
- Uso de rutas y atributos
- CRUD básico (Create, Read, Update, Delete)
- Configuración y manejo de respuestas HTTP

### 2.3 Conexión a Bases de Datos con Entity Framework Core
- ¿Qué es Entity Framework Core?
- Configuración de una base de datos con SQLite / PostgreSQL
- Migraciones de base de datos
- Relaciones entre entidades (1:N, N:M)

## Módulo 3: Desarrollo de Frontend con Angular
### 3.1 Instalación y Configuración de Angular
- Introducción a Angular CLI
- Estructura básica de un proyecto Angular
- Componentes, módulos y templates
- Data Binding y Directivas (ngIf, ngFor)

### 3.2 Servicios y Consumo de APIs en Angular
- Introducción a HttpClient para hacer peticiones HTTP
- Consumo de APIs desde Angular
- Manejo de Promesas y Observables
- Comunicación entre componentes y servicios

## Módulo 4: Conexión entre Frontend y Backend
### 4.1 Comunicación entre Angular y ASP.NET Core
- Implementación de CORS en ASP.NET Core
- Consumo de datos de la API en Angular
- Mostrar datos en componentes de Angular
- Manejo de errores HTTP en Angular

### 4.2 Autenticación y Autorización con JWT
- Introducción a JWT (JSON Web Token)
- Implementación de autenticación en ASP.NET Core
- Proteger rutas en el backend con [Authorize]
- Uso de guardias en Angular para proteger rutas

## Módulo 5: Persistencia de Datos y Manejo de Formularios
### 5.1 Persistencia de Datos en ASP.NET Core
- Guardado y lectura de datos desde la base de datos
- Uso de Repositories y Unit of Work
- Validación de datos en el servidor

### 5.2 Formularios Reactivos en Angular
- Creación de formularios en Angular
- Validaciones de formularios (requeridos, patrones)
- Envío de formularios a la API
- Manejo de errores en formularios

## Módulo 6: Desarrollo de un Proyecto Real
### 6.1 Planificación de un Proyecto
- Análisis de requerimientos
- Diseño de la arquitectura (backend y frontend)
- División en módulos y componentes

### 6.2 Implementación del Backend
- Crear endpoints para el proyecto real
- Definir el modelo de datos y entidades
- Validación de reglas de negocio en la API

### 6.3 Implementación del Frontend
- Creación de páginas con Angular (listas, formularios, detalles)
- Interacción con la API
- Estilizado básico con Bootstrap / CSS

## Módulo 7: Despliegue
### 7.1 Despliegue en Producción
- Configuración de IIS para desplegar ASP.NET Core
- Despliegue de Angular en IIS
- Uso de herramientas como Azure, AWS o Heroku para despliegue en la nube

## Módulo 8: Buenas Prácticas y Optimización
### 8.1 Buenas Prácticas de Código
- Organización del código en capas (controllers, services, repositories)
- Uso de principios SOLID
- Comentarios y documentación del código

### 8.2 Optimización y Seguridad
- Optimización de consultas en EF Core
- Seguridad en la API (control de acceso, protección de datos sensibles)
