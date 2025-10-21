using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    [SerializeField] private int numero;

    void Start()
    {
        if (numero % 2 == 0)
        {
            Debug.Log($"{numero} è un numero pari.");
        }
        else
        {
            Debug.Log($"{numero} è un numero dispari.");
        }
    }
}