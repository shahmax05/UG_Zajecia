//Utworzenie programu, który wypisuje strukturę plików dla katalogu z projektem.

//Utwórz projekt o nazwie Katalogi

//Zaimportuj pakiet IO służący do obsługi plików .Net. Dodaj using System.IO; do sekcji using w projekcie.

//Zadeklaruj statyczną metodę(Funkcja - procedura) wypiszStruktureKatalogu przyjmującą jako parametr sciezka o typie string oraz wciecie o typie string

//W ciele funkcji:
//Dla kazdej sciezki w Directory.GetFiles(sciezka) wypisuj na ekranie wciecie + sciezkaPlik.

//Po wykonaniu pierwszej pętli wykonaj drugą dla każdej sciezki w Directory.GetDirectories(sciezka) i wypisuj na ekranie wciecie + sciezkaKatalog.ToUpper() do elementu ListBox lbStruktura.

//Dla każdego katalogu (W drugiej pętli) wywołuj funkcję wypiszStruktureKatalogu (Rekurencja).

//Instrukcje w ciele wypiszStruktureKatalogu opakuj w obsługę błędów. Wiadomość wyjątku wypisuj na ekranie.
//W metodzie Main, wywołaj wypiszStruktureKatalogu, podając jako argument pierwszy Environment.CurrentDirectory (Wybranie folderu z projektem), a jako drugi argument - pusty tekst - "".