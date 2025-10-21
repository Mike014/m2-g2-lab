using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    public int numeroIntero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(
    $"La variabile è {numeroIntero}, " +
    $"il primo numero precedente è {numeroIntero - 1}, " +
    $"e il secondo numero precedente è {numeroIntero - 2}."
);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
