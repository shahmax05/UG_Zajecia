dane = [5, 2, 4, 6, 1, 3]

def sortowanie_przez_wstawianie(tab):
    t = list(tab)
    for i in range(1, len(t)):
        klucz = t[i]
        j = i - 1
        while j >= 0 and t[j] > klucz:
            t[j + 1] = t[j]
            j -= 1
        t[j + 1] = klucz
    return t

wynik = sortowanie_przez_wstawianie(dane)
print(f"Na ekranie wypisane: {wynik} {dane}")

def sortowanie_przez_wstawianie_malejaco(tab):
    t = list(tab)
    for i in range(1, len(t)):
        klucz = t[i]
        j = i - 1
        while j >= 0 and t[j] < klucz:
            t[j + 1] = t[j]
            j -= 1
        t[j + 1] = klucz
    return t

wynik_malejaco = sortowanie_przez_wstawianie_malejaco(dane)
print(f"Dodatkowe (malejąco): {wynik_malejaco}")
