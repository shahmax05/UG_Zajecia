for i in range(100, 0, -1):
    if i % 3 == 0 and i % 2 != 0:
        print(i, end=" ")
print()

i = 100
while i > 0:
    if i % 3 == 0 and i % 2 != 0:
        print(i, end=" ")
    i -= 1
print()

def sprawdz(liczba):
    if liczba % 3 == 0 and liczba % 2 != 0:
        print(liczba, end=" ")

i = 100
while True:
    sprawdz(i)
    i -= 1
    if i == 0:
        break
print()