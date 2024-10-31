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

2. **Kódbázis letöltése**:
   ```bash
   git clone https://github.com/felhasznalonev/TypeReactionApp.git
   cd TypeReactionApp
