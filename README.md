# Paralell-Image-Processing
> Autor: Michał Kaszowski
1. Wstęp
   
Stworzono aplikację okienkową demonstrującą działanie programowania równoległego na przykładzie przetwarzania obrazów. 
Działanie wątków jest zauważalne w taki sposób, że zdjęcia pojawiają się na ekranie w różnych momentach, w zależności od złożoności danego przetwarzania.



https://github.com/user-attachments/assets/5a8e07b7-f7b9-4060-8120-3692b7b5b742



2. Wykorzystane technologie
   - .NET 8.0 (Windows Forms App)
   -  Biblioteka do zarządzania wątkami niskopoziomowo `Thread`

3. Sposoby przetworzenia obrazów

Aplikacja pozwala na przetworzenie obrazu na następujące sposoby: 

- Progowanie (binarne, z progiem równym 127)
- Konturowanie (zaimplementowane z wykorzystaniem operatora Sobela)
- Wyszarzanie
- Lustrzane odbicie w poziomie

4. Najważniejsze pliki aplikacji:
   - `Form1.cs`: Plik główny w aplikacji; zawiera funkcjonalności przycisków, oraz zarządzanie wątkami.
   - `ProcessingFunctions.cs`: Plik zawierający definicje przetwarzających obraz funkcji
