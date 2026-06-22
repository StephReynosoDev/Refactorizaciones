# Codigo refactorizado a mi manera

# Aquí simplemente cambié todas las líneas que juntaban textos usando el signo de más
# + por f-strings. Así el código de los mensajes que se imprimen en pantalla se lee mucho
# más limpio y ordenado.

import network
import config
import data
import logger
import time

def ejecutar_monitorizacion() -> None:
    print("Iniciando tareas de comprobacion...")
    t1 = time.time()
    
    lista = config.obtener_hosts()
    to = config.obtener_timeout()
    
    for h in lista:
        d = h["domain"]
        print("=============================")
        print(f"Analizando objetivo: {d}")
        
        ip = network.resolver_dns(d)
        
        if ip is not None:
            print(f" -> DNS resuelto correctamente: {ip}")
            logger.registrar(f"DNS OK para {d}")
            
            data.estado_actual[d] = {"ip": ip, "puertos": {}}
            
            for p in h["ports"]:
                print(f" -> Comprobando puerto {p} ...")
                estado, ms = network.chequear_puerto(d, p, to)
                
                if estado is True:
                    print(f"    [ABIERTO] Tiempo: {round(ms, 2)} ms")
                    data.estado_actual[d]["puertos"][str(p)] = "ABIERTO"
                    data.historico.append(f"El puerto {p} en {d} esta abierto.")
                else:
                    print("    [CERRADO] El puerto no responde.")
                    data.estado_actual[d]["puertos"][str(p)] = "CERRADO"
                    logger.registrar(f"Fallo conexion TCP puerto {p} en {d}", "ERROR")
                    data.historico.append(f"INCIDENCIA: Puerto {p} cerrado en {d}")
        else:
            print(f" -> ERROR DNS: No se pudo resolver {d}")
            logger.registrar(f"Fallo DNS para {d}", "ERROR")
            data.estado_actual[d] = "CAIDO"
            data.historico.append(f"INCIDENCIA: Host {d} inaccesible (DNS)")
            
    t2 = time.time()
    print("=============================")
    print(f"Monitorizacion finalizada en {round(t2-t1, 2)} segundos.")



































# Codigo antiguo que habia que refactorizar
'''
import network
import config
import data
import logger
import time

def ejecutar_monitorizacion():
    print("Iniciando tareas de comprobacion...")
    t1 = time.time()
    
    lista = config.obtener_hosts()
    to = config.obtener_timeout()
    
    for h in lista:
        d = h["domain"]
        print("=============================")
        print("Analizando objetivo:", d)
        
        ip = network.resolver_dns(d)
        
        if ip is not None:
            print(" -> DNS resuelto correctamente:", ip)
            logger.registrar("DNS OK para " + d)
            
            data.estado_actual[d] = {"ip": ip, "puertos": {}}
            
            for p in h["ports"]:
                print(" -> Comprobando puerto", p, "...")
                estado, ms = network.chequear_puerto(d, p, to)
                
                if estado == True:
                    print("    [ABIERTO] Tiempo:", round(ms, 2), "ms")
                    data.estado_actual[d]["puertos"][str(p)] = "ABIERTO"
                    data.historico.append("El puerto " + str(p) + " en " + d + " esta abierto.")
                else:
                    print("    [CERRADO] El puerto no responde.")
                    data.estado_actual[d]["puertos"][str(p)] = "CERRADO"
                    logger.registrar("Fallo conexion TCP puerto " + str(p) + " en " + d, "ERROR")
                    data.historico.append("INCIDENCIA: Puerto " + str(p) + " cerrado en " + d)
        else:
            print(" -> ERROR DNS: No se pudo resolver", d)
            logger.registrar("Fallo DNS para " + d, "ERROR")
            data.estado_actual[d] = "CAIDO"
            data.historico.append("INCIDENCIA: Host " + d + " inaccesible (DNS)")
            
    t2 = time.time()
    print("=============================")
    print("Monitorizacion finalizada en", round(t2-t1, 2), "segundos.")
    '''