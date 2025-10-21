# Basic Unity 3D Practice – Epicode Master — m2-g2-lab

## Project Description

Questo repository raccoglie gli esercizi svolti per il Master in Game Development (Epicode).
Il progetto è una semplice scena 3D in **Unity** usata per prendere confidenza con:

* creazione di **script C#** (MonoBehaviour),
* uso dell’**Inspector** e del ciclo di vita **Start/Update**,
* **Debug.Log** per ispezionare valori e capire il flusso,
* operatori **aritmetici / di confronto / logici** e **istruzioni condizionali**,
* risoluzione di piccoli problemi algoritmici (ad es. **pari/dispari**), **soprattutto** per consolidare la logica.

---

## Learning Objectives & Demonstrated Skills

* **C# in Unity**

  * Struttura base di uno script (`class ... : MonoBehaviour`), `Start()`, `Update()`.
  * Dichiarazione di **campi** esposti in Inspector tramite `public` o `[SerializeField] private`.
  * Nomenclatura: **nome file = nome classe**.
* **Debug & Console**

  * `Debug.Log(...)`, messaggi formattati/interpolati:
    `Debug.Log($"Somma: {a+b}, Media: {(a+b+c+d)/4f}");`
* **Operatori**

  * Aritmetici: `+ - * / %` e precedenza con **parentesi**.
  * Confronto: `== != < <= > >=` → booleani.
  * Logici: `&& || !` e **operatore ternario** `cond ? A : B`.
* **Condizionali**

  * `if / else if / else` per decidere i rami di esecuzione.
* **Mini-algoritmi**

  * **Pari/Dispari**: `if (n % 2 == 0) ...`
  * **Maggiore tra due numeri**: `int max = (a > b) ? a : b;`
  * **Mappatura voto → lettera** (range decimali) semplice con `if/else`.

---

## How to Open (Unity **2022.3.62f2**)

1. Clona il repo.
2. In **Unity Hub** crea un progetto vuoto con **la stessa versione**, poi chiudi l’Editor.
3. Nel progetto appena creato **sostituisci** le cartelle `Assets/`, `Packages/`, `ProjectSettings/` con quelle del repo.
4. Riapri il progetto dall’Hub.
5. Utilizza gli `Script` come `Component` in un `EmpyObject` premi **Play**.

---

## Usage

* Seleziona un GameObject con lo script in scena.
* In **Inspector** imposta i campi (es. `a, b, c, d`).
* Avvia la scena: i risultati appaiono in **Console**.

---

## Troubleshooting

* **CS0101 / CS0111**: classe duplicata (stesso nome in più file). Mantieni **una sola** definizione o rinomina file **e** classe.
* **CS0104 ‘Debug’ ambiguous**: rimuovi `using System.Diagnostics;` oppure usa `UnityEngine.Debug.Log(...)`.
* Campi non visibili in Inspector: usa `public int x;` **oppure** `[SerializeField] private int x;` (non entrambi).


