using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    public string codigo;
    public int cantDias;
    void Start()
    {
        if (codigo == "G")
        {
            Debug.Log("Para ese período se necesitan " + (300 * cantDias));
            Debug.Log("Esta cantidad va a tener un costo de $" + (80 * 3 * cantDias));
        }
        else if (codigo == "PP")
        {
            Debug.Log("Para ese período se necesitan " + (400 * cantDias));
            Debug.Log("Esta cantidad va a tener un costo de $" + (80 * 4 * cantDias));
        }
        else if (codigo == "PG")
        {
            Debug.Log("Para ese período se necesitan " + (700 * cantDias));
            Debug.Log("Esta cantidad va a tener un costo de $" + (80 * 7 * cantDias));
        }
        else if (codigo != "G")
        {
            Debug.Log("No se puede realizar este cálculo");
        }
        else if (codigo != "PP")
        {
            Debug.Log("No se puede realizar este cálculo");
        }
        else if (codigo != "PG")
        {
            Debug.Log("No se puede realizar este cálculo");
        }
        else if (cantDias < 3)
        {
            Debug.Log("No se puede realizar este cálculo");
        }
    }
}
