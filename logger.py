# Codigo refactorizado a mi manera

# Aquí quité todo eso de crear el archivo a mano y calcular la fecha sumando textos. En su lugar configuré el 
# logging normal de Python para que haga todo ese trabajo sucio de forma automática en un solo archivo.

import logging
import os

if not os.path.exists("logs"):
    os.mkdir("logs")

logging.basicConfig(
    filename='logs/system.log', 
    level=logging.DEBUG,
    format='%(asctime)s [%(levelname)s] %(message)s'
)

def registrar(mensaje: str, tipo: str = "INFO") -> None:
    tipo = tipo.upper()
    if tipo == "ERROR":
        logging.error(mensaje)
    elif tipo == "WARNING":
        logging.warning(mensaje)
    else:
        logging.info(mensaje)
















# Codigo antiguo que habia que refactorizar
'''
import datetime
import logging
import os
from pathlib import Path

# Crear carpeta de logs si no existe
if not os.path.exists("logs"):
    os.mkdir("logs")

# Configuracion basica del logging
logging.basicConfig(filename='logs/system.log', level=logging.DEBUG)

def registrar(mensaje, tipo="INFO"):
    # Aqui escribimos manual en el archivo app.log
    ruta = Path("logs/app.log")
    f = open(ruta, "a")
    ahora = datetime.datetime.now()
    # Formateamos el string
    linea = str(ahora) + " [" + tipo + "] " + mensaje + "\n"
    f.write(linea)
    f.close()
    
    # Usamos tambien el logging por si acaso
    if tipo == "ERROR":
        logging.error(mensaje)
    elif tipo == "WARNING":
        logging.warning(mensaje)
    else:
        logging.info(mensaje)
        '''