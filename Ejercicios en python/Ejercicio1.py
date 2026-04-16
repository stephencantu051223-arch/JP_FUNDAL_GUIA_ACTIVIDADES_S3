"""Una inmobiliaria calcula el alquiler mensual según los precios unitarios:
• S/.30.00 por cada habitación
• S/.10.00 por cada baño
• S/.15.00 por cada patio
El usuario ingresa las cantidades de cada uno. Mostrar el total mensual.
Pista: total = (habitaciones × 30) + (baños × 10) + (patios × 15)"""

habi = int(input("Ingresa el número de habitaciones: "))
baño = int(input("Ingresa el número de baños: "))
patio = int(input("Ingresa el número de patios: "))

total = (habi * 30)+(baño * 10)+(patio * 15)

print(f"El monto mensual a pagar es: {total}")