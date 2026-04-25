dane = [7, 2, 1, 6, 8, 5, 3, 4, 2]

def sortowanie_szybkie(tab):
    if len(tab) <= 1:
        return list(tab)
    
    pivot = tab[len(tab) // 2]
    
    mniejsze = [x for x in tab if x < pivot]
    rowne = [x for x in tab if x == pivot]
    wieksze = [x for x in tab if x > pivot]
    
    return sortowanie_szybkie(mniejsze) + rowne + sortowanie_szybkie(wieksze)

wynik = sortowanie_szybkie(dane)
wynik_sorted = sorted(dane)

print(f"Na ekranie wypisane: Quicksort: {wynik} sorted(): {wynik_sorted}")
