# MiniCoreBackEnd - VENTAS

Este proyecto es el backend de un minicore de ventas diseñado para gestionar **ventas** y **vendedores**, así como para calcular automáticamente las comisiones de los vendedores en un rango de fechas determinado. La API está construida para facilitar el almacenamiento, consulta y cálculo de datos de ventas y comisiones.

## Índice

- [Descripción](#descripción)
- [Características](#características)
- [Tecnologías](#tecnologías)
- [Requisitos previos](#requisitos-previos)
- [Instalación](#instalación)
- [Uso](#uso)
- [Endpoints de la API](#endpoints-de-la-api)
- [Estructura del proyecto](#estructura-del-proyecto)
- [Contribución](#contribución)

## Descripción

El objetivo de este backend es proporcionar un servicio API REST que permita la gestión eficiente de ventas y vendedores, así como el cálculo de comisiones de acuerdo a un periodo de tiempo definido. Este servicio puede ser consumido por una aplicación frontend que facilite la interfaz de usuario.

## Características

- **Gestión de Ventas**: Permite la creación, lectura, actualización y eliminación de registros de ventas.
- **Gestión de Vendedores**: CRUD completo para administrar los datos de los vendedores.
- **Cálculo de Comisiones**: Realiza el cálculo automático de las comisiones en base a las ventas de un vendedor dentro de un rango de fechas.
- **Filtros por Rango de Fechas**: Configura el cálculo de comisiones especificando un rango de fechas para mayor precisión.

## Tecnologías

Este proyecto fue construido utilizando:

- **.NET Core**: Framework principal para el desarrollo de la API.
- **Entity Framework Core**: ORM para gestionar la base de datos.
- **SQL Server / MySQL**: Bases de datos compatibles para el almacenamiento de datos.
- **JWT**: Autenticación para asegurar el acceso a los endpoints.
- **AutoMapper**: Para el mapeo de modelos y DTOs.
  
## Requisitos previos

Antes de instalar y ejecutar el proyecto, asegúrate de tener lo siguiente instalado:

- **.NET Core SDK** (versión 5.0 o superior)
- **SQL Server** o **MySQL** (configurado y en ejecución)

## Instalación

Para instalar el proyecto en tu entorno local, sigue estos pasos:

1. Clona el repositorio:

   ```bash
   git clone https://github.com/krissceron/MiniCoreBackEnd.git

2. Navega al directorio del proyecto:

   ```bash
   cd MiniCoreBackEnd

3. Configura la base de datos en el archivo appsettings.json:

   ```json
   "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
}

4. Ejecuta las migraciones para configurar la base de datos:

   ```bash
   dotnet ef database update

5. Ejecuta el proyecto:

   ```bash
   dotnet run

El backend estará disponible en http://localhost:5000 o el puerto configurado.

# API de MiniCore Ventas

Esta API permite gestionar vendedores, ventas y comisiones dentro del sistema MiniCore de ventas.

## Endpoints

### Autenticación
- **POST** `/api/auth/login`: Inicia sesión y devuelve un token JWT.
- **POST** `/api/auth/register`: Registra un nuevo usuario (administrador).

### Vendedores
- **GET** `/api/vendedores`: Lista todos los vendedores.
- **POST** `/api/vendedores`: Crea un nuevo vendedor.
- **PUT** `/api/vendedores/{id}`: Actualiza la información de un vendedor.
- **DELETE** `/api/vendedores/{id}`: Elimina un vendedor.

### Ventas
- **GET** `/api/ventas`: Lista todas las ventas.
- **POST** `/api/ventas`: Registra una nueva venta.
- **PUT** `/api/ventas/{id}`: Actualiza una venta.
- **DELETE** `/api/ventas/{id}`: Elimina una venta.

### Comisiones
- **GET** `/api/comisiones?startDate={startDate}&endDate={endDate}`: Calcula la comisión de un vendedor entre las fechas indicadas.

## Estructura del Proyecto

La estructura del proyecto sigue el siguiente formato:

```bash
├── Controllers/         # Controladores de la API
├── Models/              # Modelos de datos y entidades
├── DTOs/                # Objetos de transferencia de datos
├── Repositories/        # Capa de acceso a datos
├── Services/            # Lógica de negocio
├── appsettings.json     # Configuración de la aplicación
└── Program.cs           # Punto de entrada de la aplicación
