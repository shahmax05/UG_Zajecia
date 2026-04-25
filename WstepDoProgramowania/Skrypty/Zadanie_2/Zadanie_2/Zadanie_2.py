dane = [2, 5, 8, 12, 16, 23, 27, 38, 56, 72, 91]
szukana_obecna = 27
szukana_brak = 26

def wyszukiwanie_liniowe(tab, x):
    sprawdzenia = 0
    for i in range(len(tab)):
        sprawdzenia += 1
        if tab[i] == x:
            return i, sprawdzenia
    return -1, sprawdzenia

def wyszukiwanie_binarne(tab, x):
    lewy = 0
    prawy = len(tab) - 1
    sprawdzenia = 0
    
    while lewy <= prawy:
        srodek = (lewy + prawy) // 2
        sprawdzenia += 1
        
        if tab[srodek] == x:
            return srodek, sprawdzenia
        elif tab[srodek] < x:
            lewy = srodek + 1
        else:
            prawy = srodek - 1
            
    return -1, sprawdzenia

def pokaz_wynik(nazwa_algorytmu, x, wynik):
    indeks, sprawdzenia = wynik
    if indeks != -1:
        print(f"[{nazwa_algorytmu}] Znaleziono {x} na indeksie {indeks} (liczba sprawdzeń: {sprawdzenia})")
    else:
        print(f"[{nazwa_algorytmu}] Nie znaleziono {x} (liczba sprawdzeń: {sprawdzenia})")

pokaz_wynik("Liniowe", szukana_obecna, wyszukiwanie_liniowe(dane, szukana_obecna))
pokaz_wynik("Binarne", szukana_obecna, wyszukiwanie_binarne(dane, szukana_obecna))

print("-" * 50)

pokaz_wynik("Liniowe", szukana_brak, wyszukiwanie_liniowe(dane, szukana_brak))
pokaz_wynik("Binarne", szukana_brak, wyszukiwanie_binarne(dane, szukana_brak))

print("\n" + "=" * 50)
print("ĆWICZENIE DODATKOWE - Zwracanie pierwszego indeksu")
print("=" * 50)

dane_powtorzenia = [2, 5, 8, 27, 27, 27, 27, 38, 56, 72, 91]

def wyszukiwanie_binarne_pierwszy(tab, x):
    lewy = 0
    prawy = len(tab) - 1
    sprawdzenia = 0
    znaleziony_indeks = -1
    
    while lewy <= prawy:
        srodek = (lewy + prawy) // 2
        sprawdzenia += 1
        
        if tab[srodek] == x:
            znaleziony_indeks = srodek
            prawy = srodek - 1
        elif tab[srodek] < x:
            lewy = srodek + 1
        else:
            prawy = srodek - 1
            
    return znaleziony_indeks, sprawdzenia

pokaz_wynik("Binarne (zwykłe)", 27, wyszukiwanie_binarne(dane_powtorzenia, 27))
pokaz_wynik("Binarne (pierwsze trafienie)", 27, wyszukiwanie_binarne_pierwszy(dane_powtorzenia, 27))