# Codigo refactorizado a mi manera

# En el menú principal solo agregué el tipo de datos a la función main() -> None y cambié los textos
# repetidos por f-strings para que todo el menú se vea uniforme y con buena estética.
import config
import monitor
import reports
import data
import logger
import sys

def main() -> None:
    config.cargar_configuracion()
    logger.registrar("Aplicacion PySentinel iniciada")
    
    while True:
        print("\n" + "*" * 30)
        print("      PySentinel CLI v1.0")
        print("*" * 30)
        print("1. Mostrar hosts configurados")
        print("2. Ejecutar monitorizacion de red")
        print("3. Ver estado actual de infraestructura")
        print("4. Generar reportes (JSON y TXT)")
        print("5. Consultar historial de eventos")
        print("6. Salir")
        
        opc = input("\nSeleccione una accion: ")
        
        if opc == "1":
            lista = config.obtener_hosts()
            print("\n--- Hosts Configurados ---")
            for item in lista:
                print(f"Dominio: {item['domain']} | Puertos a vigilar: {item['ports']}")
        
        elif opc == "2":
            monitor.ejecutar_monitorizacion()
            
        elif opc == "3":
            print("\n--- Estado General ---")
            if len(data.estado_actual) == 0:
                print("No hay datos. Ejecute la monitorizacion primero.")
            else:
                for k, v in data.estado_actual.items():
                    print(f"Destino: {k} -> {v}")
                    
        elif opc == "4":
            if len(data.estado_actual) == 0:
                print("\nDebe ejecutar la monitorizacion antes de generar reportes.")
            else:
                reports.generar_json()
                reports.generar_txt()
                
        elif opc == "5":
            print("\n--- Historial de Eventos ---")
            if len(data.historico) == 0:
                print("No hay eventos registrados en esta sesion.")
            else:
                for ev in data.historico:
                    print(f"- {ev}")
                    
        elif opc == "6":
            print("\nCerrando PySentinel... ¡Hasta luego!")
            logger.registrar("Aplicacion cerrada por el usuario")
            sys.exit(0)
            
        else:
            print("\nOpcion invalida. Intente de nuevo.")

if __name__ == "__main__":
    main()


































# Codigo antiguo que habia que refactorizar
'''
import config
import monitor
import reports
import data
import logger
import sys

def main():
    # inicializamos
    config.cargar_configuracion()
    logger.registrar("Aplicacion PySentinel iniciada")
    
    while True:
        print("\n" + "*" * 30)
        print("      PySentinel CLI v1.0")
        print("*" * 30)
        print("1. Mostrar hosts configurados")
        print("2. Ejecutar monitorizacion de red")
        print("3. Ver estado actual de infraestructura")
        print("4. Generar reportes (JSON y TXT)")
        print("5. Consultar historial de eventos")
        print("6. Salir")
        
        opc = input("\nSeleccione una accion: ")
        
        if opc == "1":
            lista = config.obtener_hosts()
            print("\n--- Hosts Configurados ---")
            for item in lista:
                print("Dominio:", item["domain"], "| Puertos a vigilar:", item["ports"])
        
        elif opc == "2":
            monitor.ejecutar_monitorizacion()
            
        elif opc == "3":
            print("\n--- Estado General ---")
            if len(data.estado_actual) == 0:
                print("No hay datos. Ejecute la monitorizacion primero.")
            else:
                for k, v in data.estado_actual.items():
                    print("Destino:", k, "->", v)
                    
        elif opc == "4":
            if len(data.estado_actual) == 0:
                print("\nDebe ejecutar la monitorizacion antes de generar reportes.")
            else:
                reports.generar_json()
                reports.generar_txt()
                
        elif opc == "5":
            print("\n--- Historial de Eventos ---")
            if len(data.historico) == 0:
                print("No hay eventos registrados en esta sesion.")
            else:
                for ev in data.historico:
                    print("-", ev)
                    
        elif opc == "6":
            print("\nCerrando PySentinel... ¡Hasta luego!")
            logger.registrar("Aplicacion cerrada por el usuario")
            sys.exit(0)
            
        else:
            print("\nOpcion inválida. Intente de nuevo.")

if __name__ == "__main__":
    main()
    '''