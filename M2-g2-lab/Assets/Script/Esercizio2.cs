using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    // Campo della classe (visibile in Inspector e salvato da Unity)
    [SerializeField] private int a;
    [SerializeField] private int b;
    [SerializeField] private int c;
    [SerializeField] private int d;

    void Start()
    {
        // Start viene eseguito una sola volta all’avvio
        Debug.Log($"Somma: {a + b + c + d}");
        Debug.Log($"Moltiplicazione: {a * b * c * d}");
        Debug.Log($"Media: {a + b + c + d/4}");
    }

    void Update()
    {
        // Update gira ad ogni frame (qui non lo usiamo)
    }
}
