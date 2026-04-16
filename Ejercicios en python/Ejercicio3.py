"""El usuario ingresa una temperatura en Celsius. Convertirla a Fahrenheit y a Kelvin.
Fórmulas:
Fahrenheit: F = C × (9.0/5) + 32
Kelvin: K = C + 273.15
¡Ojo en C#! 9/5 = 1 (entero). Usa 9.0/5 para obtener 1.8."""

cel = float(input("Ingresa la temperatura en Celsius: "))

fah = cel * (9/5) + 32
kel = cel + 272.15

print(f"En Fahrenheit es: {fah} y en Kelvin es: {kel}")