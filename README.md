# Car Crash - Mini-joc 2D (C# WinForms)

Acesta este un proiect personal dezvoltat în **C#** utilizând framework-ul **Windows Forms**. Jocul este de tip arcade, în care jucătorul trebuie să navigheze o mașină printre obstacole (baloți) care apar aleatoriu pe ecran.

## 🚀 Caracteristici Tehnice
* **Logică Grid-Based:** Gestionarea obstacolelor se realizează printr-o matrice bidimensională ($6 \times 4$), facilitând calculul coliziunilor și deplasarea elementelor.
* **Randare Grafică:** Utilizarea clasei `Graphics` și a obiectelor `Bitmap` pentru desenarea fluidă a elementelor (șosea, mașină, obstacole).
* **Control în Timp Real:** Gestionarea evenimentelor de tastatură (`KeyDown`) pentru deplasarea laterală a vehiculului.
* **Sistem de Animație:** Implementat prin componenta `Timer`, cu un sistem de delay variabil pentru generarea obstacolelor.

## 🎮 Cum se joacă
1. **Pornire:** Rulează aplicația din Visual Studio.
2. **Control:** Folosește tastele **Săgeată Stânga** și **Săgeată Dreapta** pentru a schimba coloana pe care se află mașina.
3. **Obiectiv:** Evită coliziunea cu baloții de paie. Jocul se termină în momentul impactului.

## 🛠️ Tehnologii utilizate
* **Limbaj:** C#
* **Platformă:** .NET (Windows Forms)
* **IDE:** Visual Studio 2022
