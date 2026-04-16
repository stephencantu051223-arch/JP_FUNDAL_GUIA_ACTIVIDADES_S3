"""Una distribuidora cobra: cargo fijo mensual S/.5.00 + S/.0.55 por kWh consumido. Al
subtotal se le aplica el IGV (18%).
El usuario ingresa los kWh consumidos. Mostrar subtotal, IGV y total.
Pista: subtotal = 5.00 + (kwh × 0.55) | igv = subtotal × 0.18 | total = subtotal + igv"""

kwh = int(input("Ingresa tu consumo kwh: "))
sub_total = 5.00 + (kwh * 0.55)
igv = sub_total * 0.18
total = sub_total + igv
print(f"El total a pagar es: {total}")