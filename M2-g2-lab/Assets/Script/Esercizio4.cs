using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int numeroIntero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(
    $"La variabile è {numeroIntero}, " +
    $"il primo numero successivo è {numeroIntero + 1}, " +
    $"e il secondo numero successivo è {numeroIntero + 2}."
);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
