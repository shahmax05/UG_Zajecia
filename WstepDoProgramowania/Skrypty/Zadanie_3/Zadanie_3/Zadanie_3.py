import math

EPSILON = 0.000001

a = float(input("Podaj liczbę nieujemną: "))

if a < 0:
    raise Exception("Liczba nie może być ujemna")

x = 1.0

while abs(x**2 - a) > EPSILON:
    x = (x + a / x) / 2

print(f"Wynik przybliżony: {x}")
print(f"Wynik math.sqrt:   {math.sqrt(a)}")