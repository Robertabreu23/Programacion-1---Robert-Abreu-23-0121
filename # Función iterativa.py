# Función iterativa
def procesar_grupos(grupos):
    contador_exito = 0
    contador_fallo = 0
    resultados = []

    for grupo in grupos:
        suma1 = grupo[0] + grupo[1]
        suma2 = grupo[2] + grupo[3]
        suma3 = grupo[4] + grupo[5]

        if suma1 == 2 * suma2 - suma3:
            base = grupo[0]
            exponente = grupo[1]
            resultado = base ** exponente
            resultados.append(resultado)
            contador_exito += 1
        else:
            contador_fallo += 1

    return resultados, contador_exito, contador_fallo

# Función recursiva
def procesar_grupos_recursiva(grupos, i=0, resultados=[], contador_exito=0, contador_fallo=0):
    if i == len(grupos):
        return resultados, contador_exito, contador_fallo

    grupo = grupos[i]
    suma1 = grupo[0] + grupo[1]
    suma2 = grupo[2] + grupo[3]
    suma3 = grupo[4] + grupo[5]

    if suma1 == 2 * suma2 - suma3:
        base = grupo[0]
        exponente = grupo[1]
        resultado = base ** exponente
        resultados.append(resultado)
        contador_exito += 1
    else:
        contador_fallo += 1

    return procesar_grupos_recursiva(grupos, i+1, resultados, contador_exito, contador_fallo)

# Ejemplo de uso
if __name__ == "__main__":
    # Crear algunos grupos de prueba
    grupos_prueba = [
        [2, 3, 1, 2, 3, 4],  # Este grupo cumple la condición
        [1, 1, 2, 2, 3, 3],  # Este grupo no cumple la condición
        [3, 2, 2, 1, 1, 2]   # Este grupo cumple la condición
    ]
    
    print("Usando función iterativa:")
    resultados, exitos, fallos = procesar_grupos(grupos_prueba)
    print(f"Resultados: {resultados}")
    print(f"Éxitos: {exitos}, Fallos: {fallos}")
    
    print("\nUsando función recursiva:")
    resultados, exitos, fallos = procesar_grupos_recursiva(grupos_prueba)
    print(f"Resultados: {resultados}")
    print(f"Éxitos: {exitos}, Fallos: {fallos}")
