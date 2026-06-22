# Codigo refactorizado a mi manera

# En este lo que hice fue ponerle los tipos de datos a las funciones (como : str o : int). Esto se 
#hace por la norma PEP 484 para que se sepa qué tipo de dato recibe y qué devuelve cada función.
import socket
import time
from typing import Tuple, Optional

def resolver_dns(host: str) -> Optional[str]:
    try:
        ip = socket.gethostbyname(host)
        return ip
    except socket.gaierror:
        return None

def chequear_puerto(host: str, p: int, timeout: float = 2.0) -> Tuple[bool, float]:
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.settimeout(timeout)
    try:
        inicio = time.time()
        s.connect((host, p))
        fin = time.time()
        s.close()
        tiempo_total = (fin - inicio) * 1000
        return True, tiempo_total
    except Exception:
        s.close()
        return False, 0.0












# Codigo antiguo que habia que refactorizar
'''
import socket
import time
import ipaddress
# import subprocess # TODO: usar para hacer pings reales al sistema operativo
# import pdb # TODO: usar para debugear conexiones lentas

def resolver_dns(host):
    # Funcion para resolver el dns
    try:
        ip = socket.gethostbyname(host)
        return ip
    except Exception as e:
        # Si falla devolvemos None
        return None

def chequear_puerto(host, p, timeout=2.0):
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.settimeout(timeout)
    
    try:
        inicio = time.time()
        s.connect((host, p))
        fin = time.time()
        s.close()
        
        tiempo_total = (fin - inicio) * 1000 # Pasar a milisegundos
        return True, tiempo_total
    except Exception as e:
        # import pdb; pdb.set_trace() # Descomentar para investigar porque falla
        return False, 0

def es_ip_valida(ip_str):
    try:
        ipaddress.ip_address(ip_str)
        return True
    except:
        return False
        '''