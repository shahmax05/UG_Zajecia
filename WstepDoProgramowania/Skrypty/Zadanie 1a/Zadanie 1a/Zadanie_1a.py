dane = [64, 34, 25, 12, 22, 11, 90]

def sortowanie_babelkowe(tab):
    t = list(tab)
    n = len(t)
    
    for i in range(n):
        zamiana = False
        
        for j in range(0, n - i - 1):
            if t[j] > t[j + 1]:
                t[j], t[j + 1] = t[j + 1], t[j]
                zamiana = True
                
        if not zamiana:
            break
            
    return t

wynik = sortowanie_babelkowe(dane)
print(f"Wynik: {wynik}  Oryginał bez zmian: {dane}")

wynik_wbudowane = sorted(dane)
print(f"\nWynik z użyciem wbudowanej funkcji sorted(dane): {wynik_wbudowane}")
