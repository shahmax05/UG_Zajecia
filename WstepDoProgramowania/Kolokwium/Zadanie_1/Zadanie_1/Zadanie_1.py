class Utilities:
    def zlicz_litery_i_cyfry(self, tekst):
        """
        Metoda sprawdza każdy znak w podanym ciągu i zlicza te, 
        które są literami lub cyframi.
        """
        licznik = 0
        for znak in tekst:
            # Metoda isalnum() zwraca True dla liter i cyfr
            if znak.isalnum():
                licznik += 1
        return licznik

# Główna część programu
if __name__ == "__main__":
    # Wyświetlenie komunikatu i pobranie danych od użytkownika
    print("Podaj wartość")
    dane_wejsciowe = input()
    
    # Utworzenie instancji klasy Utilities
    narzedzia = Utilities()
    
    # Wywołanie metody i zapisanie rezultatu
    rezultat = narzedzia.zlicz_litery_i_cyfry(dane_wejsciowe)
    
    # Wyświetlenie ostatecznego wyniku
    print(rezultat)
