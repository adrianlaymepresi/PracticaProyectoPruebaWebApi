#Principios Basicos de Rest
## 1. Cliente-Servidor:
    Separar Interfaz del usuario y su almacenamiento de datos
## 2. Sin estado:
    No se guarda sesion en el servidor (solicitud con info necesaria)
## 3. Cacheable:
    Las respuestas se almacenan en cache para mejorar el rendimiento
## 4. Interfaz Uniforme:
    Metodos HTTP y su estructura de datos
## 5. Sistema en Capas:
    El cliente no necesita saber si el servidor accede a datos directamente o a traves de intermediarios

Entra la informacion en JSON o XML
XML (volviendose obsoleto)
JSON (mas ligero y facil de leer)

{
    "id": 1,
    "nombre": "Adrian",
    "apellido": "Layme"
    "direccion": {
        "calle": "Calle Falsa 123",
        "ciudad": "Springfield",
        "pais": "USA"
    }
}

TOON (formato mas ligero para tokens para integrarlos con la IA)