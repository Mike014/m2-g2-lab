using UnityEngine;

public class Esercizio8 : MonoBehaviour
{
    public float voto;

    void Start()
    {
        string lettera;
        if (voto >= 10f) lettera = "A+";
        else if (voto >= 9f) lettera = "A";
        else if (voto >= 7f) lettera = "B";
        else if (voto >= 6f) lettera = "C";
        else if (voto >= 5f) lettera = "D";
        else lettera = "F";

        Debug.Log($"Voto {voto} → {lettera}");
    }
}

//NB: ho pensato di inserire float così da poter permettermi di lavorare sull'intero range numerico.