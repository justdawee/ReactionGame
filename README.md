# Type Reaction App

A **Type Reaction App** egy Windows Forms alkalmazás, amely a felhasználók gépelési reakcióidejét méri. A program célja, hogy a felhasználónak véletlenszerűen megjelenített betűket kell leütnie a lehető leggyorsabban. A program rögzíti és kiértékeli a reakcióidőket, megjelenítve az átlagot és a szórást, illetve lehetőséget biztosít az eredmények mentésére és betöltésére.

## Fő funkciók

- **Reakcióidő mérés**: Véletlenszerűen megjelenített karakterek leütésének idejét rögzíti.
- **Átlag és szórás**: Kiszámolja és megjeleníti a reakcióidők átlagát és szórását.
- **Adat mentése és betöltése**: Az eredmények mentése és betöltése `.csv` fájlokba alapértelmezett vagy egyéni fájlnévvel.
- **Többszörös mérés**: Alapértelmezés szerint 12 mérés elvégzése egyetlen indítással.
- **Gyorsbillentyűk**:
  - **CTRL + S**: Mentés alapértelmezett fájlba.
  - **CTRL + ALT + S**: Mentés másként egyéni fájlnévvel.
  - **CTRL + O**: Alapértelmezett fájl betöltése.
  - **CTRL + ALT + O**: Egyéni fájl betöltése.

## Beállítások

- **Kérdezz, mielőtt felülírnád a próbálkozások listáját**: Beállítási lehetőség, amely megerősítést kér a felhasználótól, mielőtt felülírná az aktuális mentést, ha már létező fájlba szeretne menteni.

## Telepítés és használat

1. **Követelmények**:
   - .NET Framework 4.8 vagy újabb verzió
   - IDE (Visual Studio / Rider)

2. **Kódbázis letöltése**:

   ```bash
   git clone https://github.com/justdawee/ReactionGame.git
   cd TypeReactionApp
   ```

3. **Projekt megnyitása IDE-ban**:
   - Nyisd meg a `TypeReactionApp.sln` fájlt.

4. **Fordítás és futtatás**:
   - Futtasd a projektet a IDE-ből (`F5`).

## Használat

1. **Mérés indítása**: Kattints az "Indítás" gombra. A program egy visszaszámlálást jelenít meg (3, 2, 1, Start), majd véletlenszerű betűket jelenít meg, amiket gyorsan le kell ütni a szövegmezőben.
2. **Reakcióidők megjelenítése**: Minden mért reakcióidő hozzáadódik a listához, és az átlag, illetve szórás automatikusan frissül.
3. **Mentés**: Az eredményeket elmentheted a menüsávban található **Fájl > Mentés** opcióval, vagy a **CTRL + S** gyorsbillentyűvel.
4. **Mentés másként**: Egyéni fájlba mentéshez használd a **Mentés másként** opciót vagy a **CTRL + ALT + S** gyorsbillentyűt.
5. **Betöltés**: Az alapértelmezett mentést betöltheted a **Betöltés** opcióval vagy a **CTRL + O** gyorsbillentyűvel. Egyéni fájl betöltéséhez használd a **Betöltés másként** opciót vagy a **CTRL + ALT + O** kombinációt.

## Fájlfelépítés

- **Form1.cs**: A program logikáját tartalmazza, beleértve a reakcióidő mérését és a statisztikák frissítését.
- **Form1.Designer.cs**: A Windows Form komponensek elrendezését és tulajdonságait tartalmazza.
- **Program.cs**: A fő belépési pont, amely inicializálja az alkalmazást.

## Licenc

Ez a projekt MIT licenc alatt áll. Bővebb információ a `LICENSE` fájlban.
