#Codigo refactorizado a mi manera

# Igual que en la configuración, aquí cambié la forma de guardar los archivos JSON y TXT usando with open. 
# Así nos aseguramos de que los reportes se guarden bien y no se corrompan los datos.
import json
import os
import data
import datetime

def crear_carpetas() -> None:
    if not os.path.exists("reports"):
        os.mkdir("reports")

def generar_json() -> None:
    crear_carpetas()
    try:
        with open("reports/resumen.json", "w", encoding="utf-8") as f:
            json.dump(data.estado_actual, f, indent=4)
        print("Reporte JSON generado en reports/resumen.json")
    except Exception as e:
        print(f"Error al generar json: {e}")

def generar_txt() -> None:
    crear_carpetas()
    try:
        with open("reports/resumen.txt", "w", encoding="utf-8") as f:
            f.write("=== REPORTE DE INFRAESTRUCTURA PYSENTINEL ===\n")
            f.write(f"Fecha: {datetime.datetime.now()}\n\n")
            
            for clave, valor in data.estado_actual.items():
                f.write(f"HOST: {clave}\n")
                if valor == "CAIDO":
                    f.write("ESTADO GENERAL: CAIDO / OFFLINE\n")
                else:
                    f.write(f"IP: {valor['ip']}\n")
                    for p_clave, p_valor in valor["puertos"].items():
                        f.write(f"  - Puerto {p_clave}: {p_valor}\n")
                f.write("\n")
        print("Reporte TXT generado en reports/resumen.txt")
    except Exception as e:
        print(f"Error al generar txt: {e}")



































#Codigo antiguo que habia que refactorizar
'''
import json
import os
import data
import datetime

def crear_carpetas():
    if not os.path.exists("reports"):
        os.mkdir("reports")

def generar_json():
    crear_carpetas()
    try:
        f = open("reports/resumen.json", "w")
        json.dump(data.estado_actual, f, indent=4)
        f.close()
        print("Reporte JSON generado en reports/resumen.json")
    except Exception as e:
        print("Error al generar json:", e)

def generar_txt():
    crear_carpetas()
    try:
        f = open("reports/resumen.txt", "w")
        f.write("=== REPORTE DE INFRAESTRUCTURA PYSENTINEL ===\n")
        f.write("Fecha: " + str(datetime.datetime.now()) + "\n\n")
        
        for clave, valor in data.estado_actual.items():
            f.write("HOST: " + clave + "\n")
            if valor == "CAIDO":
                f.write("ESTADO GENERAL: CAIDO / OFFLINE\n")
            else:
                f.write("IP: " + valor["ip"] + "\n")
                for p_clave, p_valor in valor["puertos"].items():
                    f.write("  - Puerto " + p_clave + ": " + p_valor + "\n")
            f.write("\n")
            
        f.close()
        print("Reporte TXT generado en reports/resumen.txt")
    except Exception as e:
        print("Error al generar txt:", e)
        '''