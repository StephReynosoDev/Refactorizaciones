# Codigo refactorizado a mi manera

# En este cambié los open y close por un bloque with open. Lo hice porque 
# con el with Python cierra el archivo solo si da un error y así no se queda abierto en la memoria.

import json
from typing import List, Dict, Any

def cargar_configuracion() -> Dict[str, Any]:
    try:
        with open('config.json', 'r', encoding='utf-8') as f:
            datos = f.read()
            return json.loads(datos)
    except Exception:
        return {"hosts": [], "timeout": 1.0}

def obtener_hosts() -> List[Dict[str, Any]]:
    config = cargar_configuracion()
    return config.get("hosts", [])

def obtener_timeout() -> float:
    config = cargar_configuracion()
    return float(config.get("timeout", 2.0))

















#Codigo antiguo que habia que refactorizar
'''
import json
import os

# Variable global para guardar la configuracion
CONF = {}

def cargar_configuracion():
    global CONF
    try:
        # Abrimos el json
        f = open('config.json', 'r')
        datos = f.read()
        CONF = json.loads(datos)
        f.close()
    except Exception as e:
        print("Hubo un error cargando la configuración:", e)
        # Config por defecto si falla
        CONF = {"hosts": [], "timeout": 1}

def obtener_hosts():
    return CONF.get("hosts", [])

def obtener_timeout():
    return CONF.get("timeout", 2.0)
    '''