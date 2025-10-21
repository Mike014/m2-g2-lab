using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    [SerializeField] private int a, b;
    // Start is called before the first frame update
    void Start()
    {

        if (a < b)
        {
            Debug.Log($"Il valore più basso è {a}");
        }
        else
        {
            Debug.Log($"Il valore più basso è {b}");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

