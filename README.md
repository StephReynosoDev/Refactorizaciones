# PySentinel

PySentinel es una utilidad de consola ligera diseñada para supervisar el estado de los recursos de tu infraestructura tecnológica. 

Esta herramienta permite a los administradores de sistemas y técnicos de soporte realizar comprobaciones rápidas sobre servicios, verificar la resolución DNS, comprobar la disponibilidad de puertos TCP y generar reportes sencillos del estado general de la red.

## Características

- Lista los hosts y servicios configurados.
- Verifica la resolución de nombres de dominio (DNS).
- Comprueba la disponibilidad de puertos mediante conexiones TCP.
- Mide el tiempo de respuesta aproximado de los servicios.
- Registra eventos e incidencias durante la ejecución.
- Genera reportes del estado en formato JSON y texto plano.

## Requisitos

- Python 3.8 o superior.
- No requiere dependencias externas (utiliza exclusivamente la biblioteca estándar de Python).

## Instalación y ejecución

1. Clona o descarga este directorio en tu sistema.
2. Configura tus servidores en el archivo `config.json`.
3. Ejecuta el script principal desde tu terminal:

    ```bash
    python main.py
    ```

## Estructura del proyecto

- `main.py`: Punto de entrada de la aplicación y menú interactivo.
- `monitor.py`: Contiene la lógica de iteración y supervisión de los hosts.
- `network.py`: Módulo encargado de las operaciones de red (DNS, TCP).
- `reports.py`: Utilidad para la generación de archivos de reporte.
- `logger.py`: Sistema de registro de eventos y errores.
- `config.py`: Gestor de la configuración.
- `data.py`: Almacenamiento temporal en memoria.
- `config.json`: Archivo de configuración de los objetivos a monitorizar.