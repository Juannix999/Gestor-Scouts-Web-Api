# ⛺ Gestor de Scouts - Web API & Frontend

Aplicación Full-Stack ligera y moderna desarrollada en **C#** utilizando **ASP.NET Core Minimal APIs**, acompañada de una interfaz visual propia (Frontend) y documentación interactiva mediante Swagger.

## 🚀 Tecnologías Utilizadas

* **Backend:** .NET 8, C#, ASP.NET Core Minimal APIs
* **Frontend:** HTML5, CSS3, JavaScript (Vanilla fetch API)
* **Documentación:** Swagger / OpenAPI
* **Almacenamiento:** En memoria (Listas tipadas de C#)

## ✨ Características Principales

* **Interfaz Visual Propia (`/`):** Una página web integrada que permite registrar nuevos scouts mediante un formulario interactivo y visualizar la lista en tiempo real.
* **Endpoints RESTful (`/scouts`):** API ligera con soporte para peticiones `GET` (consultar lista) y `POST` (registrar nuevos elementos).
* **Documentación Interactiva Swagger (`/swagger`):** Panel técnico para desarrolladores y reclutadores que deseen probar los esquemas de la API directamente.

## 📋 Endpoints Disponibles

| Método | Ruta | Descripción |
| :--- | :--- | :--- |
| **GET** | `/scouts` | Devuelve la lista completa de todos los scouts registrados en formato JSON. |
| **POST** | `/scouts` | Permite registrar un nuevo scout enviando un objeto JSON. |

### Ejemplo de Petición POST (JSON)

    {
      "nombre": "Mateo Soto",
      "edad": 14,
      "rama": "Pioneros"
    }

## ⚙️ Cómo ejecutar el proyecto localmente

Sigue estas instrucciones para poner en marcha el proyecto en tu máquina o entorno de desarrollo:

1. **Clona el repositorio e ingresa a la carpeta:**
   
   git clone <url-de-tu-repositorio>
   cd Gestor-Scouts-Web-Api
   

2. **Verifica que tengas .NET instalado:**
   
   dotnet --version
   

3. **Inicia el servidor:**
   Ejecuta el siguiente comando en la raíz del proyecto (donde está el archivo `.csproj` y la carpeta `wwwroot`):
   
   dotnet run
   
   *(Deja esta terminal abierta para mantener el servidor activo).*

4. **Abre la aplicación en tu navegador:**
   * 🖥️ **Interfaz Visual (Frontend):** http://localhost:5000/
   * 📚 **Documentación Swagger:** http://localhost:5000/swagger
   * 🔍 **API Directa (JSON):** http://localhost:5000/scouts

5. **Apagar el servidor:**
   Presiona Ctrl + C en la terminal cuando desees detener la aplicación.

---
Desarrollado con pasión como parte de proyectos de arquitectura backend y desarrollo full-stack.