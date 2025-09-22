<img width="1354" height="551" alt="Captura de pantalla 2025-09-22 195827" src="https://github.com/user-attachments/assets/49f376e1-2085-4622-a644-ddf2c9f9f502" />
<img width="1356" height="579" alt="Captura de pantalla 2025-09-22 195804" src="https://github.com/user-attachments/assets/136875d4-ff23-4d87-8ce5-66525f0ac496" />

CRUD Blazor con ASP.NET Core y PostgreSQL
Este es un proyecto de ejemplo que demuestra la creación de una aplicación de tipo CRUD (Crear, Leer, Actualizar, Borrar) utilizando Blazor WebAssembly en el frontend y ASP.NET Core Web API en el backend. Los datos se almacenan en una base de datos PostgreSQL.

Características
Gestión de Productos: Permite crear, visualizar, editar y eliminar productos.

API RESTful: El backend expone una API REST para interactuar con la base de datos.

Validación de Datos: Incluye validación simple en el formulario de productos.

Arquitectura en capas: El proyecto está dividido en tres capas lógicas para una mejor organización y mantenimiento: Frontend, Backend y Shared.

Inyección de Dependencias: Utiliza el sistema de inyección de dependencias de ASP.NET para la gestión de servicios como el repositorio.

Tecnologías Utilizadas
Frontend:

Blazor WebAssembly

.NET 8

HTML, CSS, Bootstrap

Backend:

ASP.NET Core Web API

.NET 8

Entity Framework Core

Npgsql (proveedor para PostgreSQL)

Base de Datos:

PostgreSQL

Prerrequisitos
Antes de empezar, asegúrate de tener instalado lo siguiente:

.NET 8 SDK: Puedes descargarlo desde el sitio oficial de Microsoft.

Visual Studio 2022 (con la carga de trabajo ASP.NET y desarrollo web) o Visual Studio Code (con las extensiones C# y Blazor).

PostgreSQL: Un servidor de base de datos PostgreSQL debe estar instalado y en funcionamiento.

Configuración e Instalación
Sigue estos pasos para poner en marcha el proyecto:

Clona el repositorio:

Bash

git clone https://github.com/mariomarquesto/CrudRezor25.git
cd CrudRezor25
Configura la base de datos:

Abre el archivo appsettings.json en el proyecto CRUD.Backend.

Actualiza la cadena de conexión DefaultConnection con la información de tu base de datos PostgreSQL.

JSON

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=tu_base_de_datos;Username=tu_usuario;Password=tu_contraseña"
}
Ejecuta las migraciones de la base de datos:
Abre una terminal en la carpeta del proyecto CRUD.Backend y ejecuta los siguientes comandos para crear la base de datos y las tablas.

Bash

dotnet ef database update
Ejecuta la aplicación:
En Visual Studio, selecciona la solución (CRUDBlazor3.sln) y ejecuta ambos proyectos al mismo tiempo (haz clic derecho en la solución -> Establecer proyectos de inicio... -> Proyectos de inicio múltiples y selecciona CRUD.Backend y CRUD.Frontend para iniciarse).

Alternativamente, puedes ejecutar cada proyecto desde su propia terminal:

Bash

# En la carpeta del backend
cd CRUD.Backend
dotnet run

# En una nueva terminal, en la carpeta del frontend
cd CRUD.Frontend
dotnet run
Autor
Mario Marquestó 
