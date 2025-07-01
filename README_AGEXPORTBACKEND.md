# AGEXPORTBACKEND

Este proyecto es el **backend** para el sistema de gestión de empleados del caso de estudio AGEXPORT.

Expone una API REST construida con **ASP.NET Core Web API** y **Entity Framework Core**, que permite realizar operaciones CRUD sobre información de empleados.

---

## 🔧 Tecnologías utilizadas

- ASP.NET Core Web API (.NET 6+)
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI
- C#

---

## 📌 Funcionalidad

Se puede gestionar información general de los empleados como:

- Nombres, apellidos
- Género, estado civil, fecha de nacimiento
- DPI, NIT
- Afiliaciones a IGSS e IRTRA
- Dirección
- Información salarial

---

## 📂 Estructura del proyecto

```
AGEXPORTBACKEND/
├── Controllers/
│   └── EmpleadosController.cs
├── Models/
│   └── Empleado.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Program.cs
├── appsettings.json
└── ...
```

---

## ▶️ Cómo ejecutar el backend

### 1. Requisitos

- .NET SDK 6.0 o superior
- SQL Server
- Visual Studio o VS Code

### 2. Configurar la cadena de conexión

Edita `appsettings.json` con tu servidor y base de datos local:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=TU_SERVIDOR;Database=NombreBD;Trusted_Connection=True;"
}
```

### 3. Ejecutar migraciones (opcional)

```bash
dotnet ef database update
```

### 4. Ejecutar la API

```bash
dotnet run
```

La API estará disponible en:

```
https://localhost:{puerto}/swagger
```

---

## 🔗 Endpoints principales

| Verbo | Ruta                   | Descripción               |
|-------|------------------------|---------------------------|
| GET   | /api/empleados         | Listar empleados          |
| GET   | /api/empleados/{id}    | Obtener empleado por ID   |
| POST  | /api/empleados         | Crear nuevo empleado      |
| PUT   | /api/empleados/{id}    | Actualizar empleado       |
| DELETE| /api/empleados/{id}    | Eliminar empleado         |

---

## 👨‍💻 Autor

Desarrollado por [@jagodoy2012](https://github.com/jagodoy2012) como parte del caso de estudio de AGEXPORT.

---